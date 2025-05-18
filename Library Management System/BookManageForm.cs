using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BookManageForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        
        public BookManageForm()
        {
            InitializeComponent();
        }

        private void BookManageForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewManageBook.DataSource = dt;
            }
        }

        private void ClearFields()
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtCategory.Clear();
            txtAuthor.Clear();
            txtQuantity.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Id, Name, Category, Author, AvailableQuantity, CreatedDateTime) " +
                               "VALUES (@Id, @Name, @Category, @Author, @Quantity, @CreatedDateTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtBookId.Text);
                cmd.Parameters.AddWithValue("@Name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@CreatedDateTime", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBooks();
        }

        private void btnDeleteInfor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                MessageBox.Show("Vui lòng nhập Book ID cần xóa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Books WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtBookId.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách với ID đã nhập.");
                }
            }

            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Category = @Category, Author = @Author, " +
                               "AvailableQuantity = @Quantity WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBooks();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "";

                // Nếu checkbox "Borrowed" được tick
                if (chkBorrowed.Checked)
                {
                    // Hiển thị sách đang có người mượn
                    query = @"SELECT bk.Id, bk.Name, bk.Category, bk.Author, bk.AvailableQuantity 
                      FROM Books bk
                      WHERE bk.Id IN (SELECT DISTINCT BookId FROM Borrow WHERE EndDateTime IS NULL OR EndDateTime > GETDATE())";
                }
                else
                {
                    // Tìm theo tên sách như cũ
                    query = "SELECT * FROM Books WHERE Name = @Name";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!chkBorrowed.Checked)
                {
                    // Chỉ khi không check thì mới cần thêm @Name
                    cmd.Parameters.AddWithValue("@Name", txtBookName.Text);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewManageBook.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
