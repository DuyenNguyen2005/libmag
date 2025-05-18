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
    public partial class EditEmployeeForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        private byte[] picture;
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtID.Text.Trim(), out id))
            {
                MessageBox.Show("ID không hợp lệ.", "Lỗi");
                return;
            }

            // Thông tin từ giao diện
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = cbEmail.Text.Trim();
            string address = txtAddress.Text.Trim();

            byte[] pictureData = null;
            if (picEmployee.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picEmployee.Image.Save(ms, picEmployee.Image.RawFormat);
                    pictureData = ms.ToArray();
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Chỉ cập nhật bảng Employee
                        string updateEmployee = @"UPDATE Employee SET 
                                          FirstName = @FirstName, 
                                          LastName = @LastName, 
                                          Phone = @Phone, 
                                          Email = @Email, 
                                          Address = @Address, 
                                          Picture = @Picture 
                                          WHERE Id = @Id";

                        using (SqlCommand cmdEmp = new SqlCommand(updateEmployee, conn, transaction))
                        {
                            cmdEmp.Parameters.AddWithValue("@Id", id);
                            cmdEmp.Parameters.AddWithValue("@FirstName", firstName);
                            cmdEmp.Parameters.AddWithValue("@LastName", lastName);
                            cmdEmp.Parameters.AddWithValue("@Phone", phone);
                            cmdEmp.Parameters.AddWithValue("@Email", email);
                            cmdEmp.Parameters.AddWithValue("@Address", address);
                            cmdEmp.Parameters.Add("@Picture", SqlDbType.VarBinary).Value = (object)pictureData ?? DBNull.Value;
                            cmdEmp.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Cập nhật thành công!", "Thành công");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi");
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Email FROM Login WHERE Email IS NOT NULL AND Email <> ''";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbEmail.Items.Add(reader["Email"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải email: {ex.Message}", "Lỗi");
            }
        }

        private void cbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmail = cbEmail.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FirstName, LastName FROM Login WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", selectedEmail);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin tài khoản: {ex.Message}", "Lỗi");
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picEmployee.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                // Chuyển ảnh thành byte[] để lưu vào cơ sở dữ liệu
                using (MemoryStream ms = new MemoryStream())
                {
                    picEmployee.Image.Save(ms, picEmployee.Image.RawFormat);
                    picture = ms.ToArray(); // Cập nhật biến picture
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
