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
    public partial class LoginForm: Form
    {
        string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Xác thực dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên người dùng và mật khẩu.", "Lỗi Xác Thực");
                return;
            }

            string selectedRole = GetSelectedRole();
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng chọn vai trò.", "Lỗi Xác Thực");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    string roleFromDb = null;
                    int? loginId = null;

                    // Kiểm tra trong bảng Login
                    query = "SELECT id, role FROM [Login] WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loginId = reader.GetInt32(0);
                                roleFromDb = reader.GetString(1);
                            }
                        }
                    }

                    if (roleFromDb != null && loginId.HasValue)
                    {
                        if (roleFromDb != selectedRole)
                        {
                            MessageBox.Show("Vai trò không khớp với thông tin đăng nhập.", "Lỗi Đăng Nhập");
                            return;
                        }

                        MessageBox.Show("Đăng nhập thành công!", "Thành Công");

                        // Cập nhật thời gian đăng nhập và trạng thái
                        string updateQuery = "UPDATE [Login] SET LoginDateTime = @now, Status = 1 WHERE Id = @id";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@now", DateTime.Now);
                            updateCmd.Parameters.AddWithValue("@id", loginId.Value);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Hiển thị form tương ứng dựa trên role
                        switch (selectedRole)
                        {
                            case "Student":
                            case "Teacher":
                                UserForm userForm = new UserForm(loginId.Value);
                                userForm.Show();
                                break;
                            case "Librarian":
                                MainForm mainForm = new MainForm(loginId.Value);
                                mainForm.Show();
                                break;
                            case "Administrator":
                                AdminForm adminForm = new AdminForm(loginId.Value);
                                adminForm.Show();
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng.", "Lỗi Đăng Nhập");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi Cơ Sở Dữ Liệu");
            }
        }

        private string GetSelectedRole()
        {
            if (rdoStudent.Checked) return "Student";
            if (rdoTeacher.Checked) return "Teacher";
            if (rdoAdmin.Checked) return "Administrator";
            if (rdoLibrarian.Checked) return "Librarian";
            return string.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rdoStudent.Checked = true;
        }

        private void linkCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm form = new CreateAccountForm();
            form.Show();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
