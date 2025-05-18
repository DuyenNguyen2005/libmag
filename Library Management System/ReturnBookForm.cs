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
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class ReturnBookForm: Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void LoadBorrowList()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    b.UserId,
                    u.Name AS UserName,
                    u.PhoneNumber,
                    bo.Name AS BookName,
                    b.StartDateTime,
                    b.EndDateTime,
                    b.ReturnDateTime,
                    b.BorrowStatus
                FROM 
                    Borrow b
                INNER JOIN 
                    Users u ON b.UserId = u.Id
                INNER JOIN 
                    Books bo ON b.BookId = bo.Id
                WHERE 
                    b.BorrowStatus = 1";  // Chỉ hiện sách đang mượn


                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewReturn.DataSource = dt;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Lấy thông tin user và sách
                int userId = int.Parse(txtUserId.Text.Trim());
                string bookName = txtBookName.Text.Trim();
                DateTime now = DateTime.Now;

                // Tìm BookId
                SqlCommand cmdBook = new SqlCommand("SELECT Id FROM Books WHERE Name = @name", conn);
                cmdBook.Parameters.AddWithValue("@name", bookName);
                SqlDataReader readerBook = cmdBook.ExecuteReader();

                if (!readerBook.Read())
                {
                    MessageBox.Show("Không tìm thấy sách.");
                    return;
                }

                int bookId = (int)readerBook["Id"];
                readerBook.Close();

                // Kiểm tra người dùng tồn tại
                SqlCommand cmdCheckUser = new SqlCommand("SELECT Name FROM Users WHERE Id = @userId", conn);
                cmdCheckUser.Parameters.AddWithValue("@userId", userId);
                object result = cmdCheckUser.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Không tìm thấy người dùng.");
                    return;
                }

                // Cập nhật lại số lượng sách
                SqlCommand updateQty = new SqlCommand("UPDATE Books SET AvailableQuantity = AvailableQuantity + 1 WHERE Id = @bookId", conn);
                updateQty.Parameters.AddWithValue("@bookId", bookId);
                updateQty.ExecuteNonQuery();

                // Cập nhật trạng thái mượn về 0 (đã trả) + thời gian trả
                SqlCommand updateBorrowStatus = new SqlCommand(@"
            UPDATE Borrow
            SET BorrowStatus = 0, ReturnDateTime = @returnDate
            WHERE UserId = @userId AND BookId = @bookId AND BorrowStatus = 1", conn);
                updateBorrowStatus.Parameters.AddWithValue("@userId", userId);
                updateBorrowStatus.Parameters.AddWithValue("@bookId", bookId);
                updateBorrowStatus.Parameters.AddWithValue("@returnDate", now);
                updateBorrowStatus.ExecuteNonQuery();

                // Trả sách trễ?
                SqlCommand cmdGetEndDate = new SqlCommand(@"
            SELECT EndDateTime FROM Borrow
            WHERE UserId = @userId AND BookId = @bookId AND BorrowStatus = 0 AND ReturnDateTime = @returnDate", conn);
                cmdGetEndDate.Parameters.AddWithValue("@userId", userId);
                cmdGetEndDate.Parameters.AddWithValue("@bookId", bookId);
                cmdGetEndDate.Parameters.AddWithValue("@returnDate", now);
                object endDateObj = cmdGetEndDate.ExecuteScalar();

                if (endDateObj != null && now > Convert.ToDateTime(endDateObj))
                {
                    MessageBox.Show("Trả sách trễ! Vui lòng đóng phí phạt.");
                }

                // Hỏi về tình trạng sách
                DialogResult damageCheck = MessageBox.Show("Sách có bị hư hỏng hoặc mất không?", "Tình trạng sách", MessageBoxButtons.YesNoCancel);
                if (damageCheck == DialogResult.Yes)
                {
                    DamageForm damageForm = new DamageForm();
                    damageForm.ShowDialog();
                }

                MessageBox.Show("Hoàn tất xử lý trả sách.");
                LoadBorrowList();  // Cập nhật lại danh sách đang mượn
                ClearForm();
            }
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            LoadBorrowList();
        }

        private void ClearForm()
        {
            txtUserId.Clear();
            txtName.Clear();
            txtNumber.Clear();
            txtBookName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
