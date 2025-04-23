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

namespace Library_Management_System
{
    public partial class DamageForm: Form
    {
        public DamageForm()
        {
            InitializeComponent();
        }

        private void LoadDamageData()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT RecordID, BookID, UserID, ReportDate, Type, Description, IsResolved
                         FROM DamagedOrLostBooks";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewDamageReport.DataSource = table;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || cbType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập Mã sách và chọn loại thiệt hại.");
                return;
            }

            int bookID = Convert.ToInt32(txtBookId.Text.Trim());
            int? userID = string.IsNullOrWhiteSpace(txtUserId.Text) ? (int?)null : Convert.ToInt32(txtUserId.Text.Trim());
            string type = cbType.SelectedItem.ToString();
            string desc = txtDescription.Text.Trim();
            DateTime reportDate = DateTime.Now.Date;

            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Thêm bản ghi thiệt hại
                    SqlCommand insertCmd = new SqlCommand(@"
                INSERT INTO DamagedOrLostBooks (BookID, UserID, ReportDate, Type, Description)
                VALUES (@bookID, @userID, @reportDate, @type, @desc)", conn, transaction);

                    insertCmd.Parameters.AddWithValue("@bookID", bookID);
                    insertCmd.Parameters.AddWithValue("@userID", userID.HasValue ? (object)userID : DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@reportDate", reportDate);
                    insertCmd.Parameters.AddWithValue("@type", type);
                    insertCmd.Parameters.AddWithValue("@desc", desc);

                    insertCmd.ExecuteNonQuery();

                    // 2. Trừ số lượng sách khả dụng
                    SqlCommand updateCmd = new SqlCommand(@"
                UPDATE Books
                SET AvailableQuantity = AvailableQuantity - 1
                WHERE Id = @bookID AND AvailableQuantity > 0", conn, transaction);

                    updateCmd.Parameters.AddWithValue("@bookID", bookID);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không thể cập nhật số lượng sách (sách có thể đã hết).");
                        return;
                    }

                    transaction.Commit();
                    MessageBox.Show("Đã ghi nhận thiệt hại và cập nhật số lượng sách.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void DamageForm_Load(object sender, EventArgs e)
        {
            LoadDamageData();
        }
    }
}
