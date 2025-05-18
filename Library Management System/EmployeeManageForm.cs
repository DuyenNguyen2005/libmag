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
    public partial class EmployeeManageForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        private int loginId;
        public EmployeeManageForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void btnEditEmploee_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
            editEmployeeForm.ShowDialog();
        }

        private void EmployeeManageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveEmployeeID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn ID của nhân viên để xóa.", "Cảnh báo");
                return;
            }

            int id;
            if (!int.TryParse(txtEmployeeID.Text, out id))
            {
                MessageBox.Show("ID phải là số nguyên hợp lệ.", "Lỗi");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM [Employee] WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa nhân viên thành công!", "Thành Công");
                                txtEmployeeID.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên với ID này.", "Lỗi");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi");
                }
            }
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            EmployeeListForm contactListForm = new EmployeeListForm();
            contactListForm.ShowDialog();
            if (contactListForm.SelectedEmployeeId.HasValue)
            {
                txtEmployeeID.Text = contactListForm.SelectedEmployeeId.Value.ToString();
            }
        }

        private void btnShowFullList_Click(object sender, EventArgs e)
        {
            ShowFullListForm showFullListForm = new ShowFullListForm();
            showFullListForm.ShowDialog();
        }
    }
}
