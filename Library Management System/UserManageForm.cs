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

        void ClearFields()
        {
            txtUserId.Clear();
            txtName.Clear();
            txtNumber.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name, Gender, PhoneNumber) VALUES (@Name, @Gender, @PhoneNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);

                // Gán trực tiếp giới tính
                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : null);
                cmd.Parameters.AddWithValue("@Gender", (object)gender ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(txtNumber.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Name = @Name, Gender = @Gender, PhoneNumber = @PhoneNumber WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtUserId.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);

                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : null);
                cmd.Parameters.AddWithValue("@Gender", (object)gender ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(txtNumber.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
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
