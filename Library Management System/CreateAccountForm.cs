using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Library_Management_System
{
    public partial class CreateAccountForm: Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True;Connect Timeout=30";
        private string randomCode;
        private string userEmail;
        private byte[] picture;
        public CreateAccountForm()
        {
            InitializeComponent();
            // Thêm các lựa chọn vào combo box Role
            cbRole.Items.AddRange(new string[] { "Student", "Teacher", "Administrator", "Librarian" });
            cbRole.SelectedIndex = 0; // Mặc định chọn "student"
        }

        private bool EmailExists(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Email = @Email", conn);
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra Email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Giả sử tồn tại để ngăn tạo trùng nếu có lỗi
            }
        }

        private bool IdExists(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Id = @Id", conn);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(id);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra ID: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool UsernameExists(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE UserName = @Username", conn);
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra Username: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        private bool VerifyCode()
        {
            if (txtCode.Text.Trim() == randomCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Mã xác minh không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmailExists(txtEmail.Text))
            {
                MessageBox.Show("Email này đã được đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Random rand = new Random();
                randomCode = rand.Next(100000, 999999).ToString();
                userEmail = txtEmail.Text.Trim();

                MailMessage message = new MailMessage();
                message.From = new MailAddress("nttduyen2005@gmail.com", "Quản lý Thư Viện");
                message.To.Add(userEmail);
                message.Subject = "Mã Xác Minh Đăng Ký";
                message.Body = $"Mã xác minh của bạn là: {randomCode}\nMã có hiệu lực trong vòng 2 phút.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("nttduyen2005@gmail.com", "oych idav equo olew"); // App password
                smtp.Send(message);

                MessageBox.Show("Mã xác minh đã được gửi!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtRePassword.Text.Trim();
            string role = cbRole.Text.Trim();
            string email = txtEmail.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng ID
            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("ID phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu trùng khớp
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ID trùng
            if (IdExists(id))
            {
                MessageBox.Show("ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra Username trùng
            if (UsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lưu vào CSDL
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Login (Id, UserName, Password, LoginDateTime, Status, FirstName, LastName, Email, Role) " +
                                   "VALUES (@Id, @Username, @Password, @LoginDateTime, @Status, @FirstName, @LastName, @Email, @Role)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(id);
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;
                    cmd.Parameters.Add("@LoginDateTime", SqlDbType.SmallDateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = true;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                    cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 50).Value = role;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
