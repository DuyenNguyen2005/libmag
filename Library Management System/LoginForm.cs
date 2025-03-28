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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserType FROM Users WHERE UserCode = @userCode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userCode", txtUsername.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int userType = Convert.ToInt32(result);

                        if (userType == 1)
                        {
                            MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Mở giao diện quản trị
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (userType == 2)
                        {
                            MessageBox.Show("Welcome, User!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Mở giao diện người dùng bình thường
                            UserForm userForm = new UserForm();
                            userForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserCode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
