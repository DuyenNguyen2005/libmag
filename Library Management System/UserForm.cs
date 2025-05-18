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
    public partial class UserForm: Form
    {
        string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
        private int loginId;
        public UserForm(int loginId)
        {
            InitializeComponent();
            this.loginId = loginId;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBookForm findBookForm = new FindBookForm();
            findBookForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Login SET Status = 0 WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", loginId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Mở lại form login
            new LoginForm().Show();
            this.Close(); // hoặc this.Hide();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
