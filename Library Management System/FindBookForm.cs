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
    public partial class FindBookForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public FindBookForm()
        {
            InitializeComponent();
        }

        private void FindBookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    b.Id AS [Book ID],
                    b.Name AS [Book Name],
                    b.Category,
                    b.Author,
                    b.AvailableQuantity AS [Available Quantity],
                    CASE 
                        WHEN EXISTS (
                            SELECT 1 FROM Borrow br 
                            WHERE br.BookId = b.Id AND br.BorrowStatus = 1 AND br.ReturnDateTime IS NULL
                        )
                        THEN N'Đã mượn'
                        ELSE N'Chưa mượn'
                    END AS [Borrow Status]
                FROM Books b
                WHERE 
                    (@BookID IS NULL OR b.Id = @BookID) AND
                    (@Name IS NULL OR b.Name LIKE '%' + @Name + '%') AND
                    (@Category IS NULL OR b.Category LIKE '%' + @Category + '%') AND
                    (@Author IS NULL OR b.Author LIKE '%' + @Author + '%')";

                SqlCommand cmd = new SqlCommand(query, con);

                // Gán giá trị từ TextBox, dùng DBNull nếu chuỗi rỗng
                cmd.Parameters.AddWithValue("@BookID", string.IsNullOrWhiteSpace(txtBookId.Text) ? DBNull.Value : (object)int.Parse(txtBookId.Text));
                cmd.Parameters.AddWithValue("@Name", string.IsNullOrWhiteSpace(txtBookName.Text) ? DBNull.Value : (object)txtBookName.Text);
                cmd.Parameters.AddWithValue("@Category", string.IsNullOrWhiteSpace(txtCategory.Text) ? DBNull.Value : (object)txtCategory.Text);
                cmd.Parameters.AddWithValue("@Author", string.IsNullOrWhiteSpace(txtAuthor.Text) ? DBNull.Value : (object)txtAuthor.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridViewSearch.DataSource = dt;
            }
        }
    }
}
