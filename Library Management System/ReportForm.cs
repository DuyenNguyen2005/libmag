using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace Library_Management_System
{
    public partial class ReportForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadBooksByCategory()
        {
            chartBooksByCategory.Series.Clear();
            chartBooksByCategory.Series.Add("Books");
            chartBooksByCategory.Series["Books"].ChartType = SeriesChartType.Column;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT Category, COUNT(*) AS Count
            FROM Books
            WHERE CreatedDateTime BETWEEN @From AND @To
            GROUP BY Category";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@To", dtpTo.Value);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartBooksByCategory.Series["Books"].Points.AddXY(reader["Category"].ToString(), Convert.ToInt32(reader["Count"]));
                }
                con.Close();
            }
        }

        private void LoadBorrowFrequency()
        {
            chartBorrowFrequency.Series.Clear();
            chartBorrowFrequency.Series.Add("Borrows");
            chartBorrowFrequency.Series["Borrows"].ChartType = SeriesChartType.Column;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT CAST(StartDateTime AS DATE) AS BorrowDate, COUNT(*) AS Count
            FROM Borrow
            WHERE StartDateTime BETWEEN @From AND @To
            GROUP BY CAST(StartDateTime AS DATE)
            ORDER BY BorrowDate";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@To", dtpTo.Value);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartBorrowFrequency.Series["Borrows"].Points.AddXY(reader["BorrowDate"].ToString(), Convert.ToInt32(reader["Count"]));
                }
                con.Close();
            }
        }

        private void LoadActiveUsers()
        {
            chartActiveUsers.Series.Clear();
            chartActiveUsers.Series.Add("Users");
            chartActiveUsers.Series["Users"].ChartType = SeriesChartType.Column;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT u.Name, COUNT(*) AS BorrowCount
            FROM Borrow b
            JOIN Users u ON b.UserId = u.Id
            WHERE b.StartDateTime BETWEEN @From AND @To
            GROUP BY u.Name
            ORDER BY BorrowCount DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@To", dtpTo.Value);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartActiveUsers.Series["Users"].Points.AddXY(reader["Name"].ToString(), Convert.ToInt32(reader["BorrowCount"]));
                }
                con.Close();
            }
        }

        private void LoadBookConditions()
        {
            chartBookCondition.Series.Clear();
            chartBookCondition.Series.Add("Condition");
            chartBookCondition.Series["Condition"].ChartType = SeriesChartType.Column;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                Type, 
                COUNT(*) AS Count
            FROM 
                DamagedOrLostBooks
            WHERE 
                ReportDate BETWEEN @From AND @To
            GROUP BY 
                Type";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@To", dtpTo.Value.Date);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader["Type"].ToString();
                    int count = Convert.ToInt32(reader["Count"]);
                    chartBookCondition.Series["Condition"].Points.AddXY(type, count);
                }
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            cbCategory.SelectedIndex = -1;
            btnOk.PerformClick(); // Gọi lại btnOK để vẽ biểu đồ
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string templatePath = @"C:\Users\Lenovo\Documents\Zalo Received Files\Temp.docx";
            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Library_Report.docx");

            // Lấy dữ liệu
            string fromDate = dtpFrom.Value.ToString("dd/MM/yyyy");
            string toDate = dtpTo.Value.ToString("dd/MM/yyyy");
            string bookConditions = GetBookConditionSummary();

            // Copy template sang file mới
            File.Copy(templatePath, savePath, true);

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(savePath, true))
            {
                var body = wordDoc.MainDocumentPart.Document.Body;

                foreach (var text in body.Descendants<Text>())
                {
                    if (text.Text.Contains("{FromDate}"))
                        text.Text = text.Text.Replace("{FromDate}", fromDate);
                    if (text.Text.Contains("{ToDate}"))
                        text.Text = text.Text.Replace("{ToDate}", toDate);
                    if (text.Text.Contains("{BookConditions}"))
                        text.Text = text.Text.Replace("{BookConditions}", bookConditions);
                }

                wordDoc.MainDocumentPart.Document.Save();
            }

            MessageBox.Show("Xuất báo cáo thành công ra Desktop!");
        }

        private string GetBookConditionSummary()
        {
            StringBuilder sb = new StringBuilder();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                Type, COUNT(*) AS Count
            FROM DamagedOrLostBooks
            WHERE ReportDate BETWEEN @From AND @To
            GROUP BY Type";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@To", dtpTo.Value.Date);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader["Type"].ToString();
                    int count = Convert.ToInt32(reader["Count"]);
                    sb.AppendLine($"{type}: {count} sách");
                }
                con.Close();
            }

            return sb.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadBooksByCategory();
            LoadBorrowFrequency();
            LoadActiveUsers();
            LoadBookConditions();
        }

        private void LoadCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("Tất cả"); // tùy chọn lọc tất cả

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Category FROM Books";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbCategory.Items.Add(reader["Category"].ToString());
                }

                con.Close();
            }

            cbCategory.SelectedIndex = 0; // chọn "Tất cả" mặc định
        }
    }
}
