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
    public partial class MainForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        private int loginId;

        public MainForm(int loginId)
        {
            InitializeComponent();
            this.loginId = loginId;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowForm = new BorrowBookForm();
            borrowForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBookForm findBookForm = new FindBookForm();
            findBookForm.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManageForm bookManageForm = new BookManageForm();
            bookManageForm.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManageForm userManageForm = new UserManageForm();
            userManageForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
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
    }
}
