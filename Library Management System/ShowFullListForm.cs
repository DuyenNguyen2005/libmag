using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ShowFullListForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public ShowFullListForm()
        {
            InitializeComponent();
        }

        private void ShowFullListForm_Load(object sender, EventArgs e)
        {
            dgvShowEmp.RowTemplate.Height = 140;
            dgvShowEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Employee";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(reader);

                    // Chuyển đổi cột ảnh từ byte[] thành Image
                    if (!table.Columns.Contains("PictureDisplay"))
                        table.Columns.Add("PictureDisplay", typeof(Image));

                    foreach (DataRow row in table.Rows)
                    {
                        if (row["Picture"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])row["Picture"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                row["PictureDisplay"] = Image.FromStream(ms);
                            }
                        }
                    }

                    // Gán vào DataGridView
                    dgvShowEmp.DataSource = table;

                    // Ẩn cột gốc Picture (byte[]) và hiển thị ảnh mới
                    dgvShowEmp.Columns["Picture"].Visible = false;

                    if (dgvShowEmp.Columns.Contains("PictureDisplay"))
                    {
                        dgvShowEmp.Columns["PictureDisplay"].HeaderText = "Picture";
                        ((DataGridViewImageColumn)dgvShowEmp.Columns["PictureDisplay"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu nhân viên: {ex.Message}", "Lỗi");
            }
        }
    }
}
