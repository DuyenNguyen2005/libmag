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
    public partial class UserManageForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public UserManageForm()
        {
            InitializeComponent();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadAvailableEmails();
        }

        void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewManageUser.DataSource = dt;
            }
        }

        void LoadAvailableEmails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT Email 
                    FROM Login
                    WHERE Email IS NOT NULL AND
                          Email NOT IN (SELECT Email FROM Users WHERE Email IS NOT NULL)
                          AND Email NOT IN (SELECT Email FROM Employee WHERE Email IS NOT NULL)
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cbEmail.Items.Clear();

                while (reader.Read())
                {
                    cbEmail.Items.Add(reader["Email"].ToString());
                }

                reader.Close();
            }
        }

        void ClearFields()
        {
            txtUserId.Clear();
            txtName.Clear();
            txtNumber.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cbEmail.SelectedIndex = -1;
        }

        private bool IsUserIdExists(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);

            if (IsUserIdExists(id))
            {
                MessageBox.Show("User ID already exists. Please use another ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Id, Name, Gender, PhoneNumber, Role, Email) VALUES (@Id, @Name, @Gender, @PhoneNumber, @Role, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : null);
                cmd.Parameters.AddWithValue("@Gender", (object)gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(txtNumber.Text));
                cmd.Parameters.AddWithValue("@Role", "User"); // hoặc gán từ dropdown nếu có
                cmd.Parameters.AddWithValue("@Email", cbEmail.SelectedItem?.ToString() ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            LoadAvailableEmails();
            ClearFields();
        }

        private void btnDeleteInfor_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtUserId.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            LoadAvailableEmails();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Name = @Name, Gender = @Gender, PhoneNumber = @PhoneNumber, Role = @Role, Email = @Email WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtUserId.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : null);
                cmd.Parameters.AddWithValue("@Gender", (object)gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(txtNumber.Text));
                cmd.Parameters.AddWithValue("@Role", "User");
                cmd.Parameters.AddWithValue("@Email", cbEmail.SelectedItem?.ToString() ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadUsers();
            LoadAvailableEmails();
            ClearFields();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtUserId.Text));
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtNumber.Text = reader["PhoneNumber"].ToString();
                    string gender = reader["Gender"].ToString();
                    rdoMale.Checked = gender == "Male";
                    rdoFemale.Checked = gender == "Female";
                    cbEmail.SelectedItem = reader["Email"].ToString();
                }

                reader.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
