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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Login WHERE UserName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text.Trim());

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // Cập nhật LoginDateTime và Status = 1 (Online)
                        string updateQuery = "UPDATE Login SET LoginDateTime = @loginTime, Status = 1 WHERE UserName = @userName";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@loginTime", DateTime.Now);
                            updateCmd.Parameters.AddWithValue("@userName", txtUsername.Text.Trim());
                            updateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở form chính
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
