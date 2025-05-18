using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class EmployeeListForm: Form
    {
        private string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
        private int? loginId;
        public int? SelectedEmployeeId { get; private set; }
        public EmployeeListForm(int? id = null)
        {
            InitializeComponent();
            this.loginId = id;

        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            dgvEmployee.AutoGenerateColumns = true;
            LoadContactData();
        }

        private void LoadContactData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (loginId.HasValue)
                    {
                        query = "SELECT Id, FirstName, LastName, Phone, Email, Address FROM Employee WHERE Id = @Id";
                    }
                    else
                    {
                        query = "SELECT Id, FirstName, LastName, Phone, Email, Address FROM Employee";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (loginId.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@Id", loginId.Value);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEmployee.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi");
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                SelectedEmployeeId = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
