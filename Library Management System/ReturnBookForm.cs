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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Borrow", conn);
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

                // Lấy thông tin user
                int userId = int.Parse(txtUserId.Text.Trim());
                string bookName = txtBookName.Text.Trim();
                DateTime now = DateTime.Now;

                // Tìm BookId và AvailableQuantity
                SqlCommand cmdBook = new SqlCommand("SELECT Id, AvailableQuantity FROM Books WHERE Name = @name", conn);
                cmdBook.Parameters.AddWithValue("@name", bookName);
                SqlDataReader readerBook = cmdBook.ExecuteReader();

                if (!readerBook.Read())
                {
                    MessageBox.Show("Không tìm thấy sách.");
                    return;
                }

                int bookId = (int)readerBook["Id"];
                int availableQuantity = (int)readerBook["AvailableQuantity"];
                readerBook.Close();

                if (availableQuantity <= 0)
                {
                    MessageBox.Show("Không còn sách để mượn.");
                    return;
                }

                // Kiểm tra người dùng là giáo viên hay sinh viên
                SqlCommand cmdCheckUser = new SqlCommand("SELECT Name FROM Users WHERE Id = @userId", conn);
                cmdCheckUser.Parameters.AddWithValue("@userId", userId);
                object result = cmdCheckUser.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Không tìm thấy người dùng.");
                    return;
                }

                bool isTeacher = MessageBox.Show("Người này có phải là giáo viên không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes;
                int borrowDays = isTeacher ? 15 : 5;
                DateTime expectedReturn = now.AddDays(borrowDays);

                // Ghi thông tin mượn
                SqlCommand cmdInsert = new SqlCommand(@"
            INSERT INTO Borrow (UserId, BookId, StartDateTime, EndDateTime, CreatedDateTime, ReturnDateTime, BorrowStatus)
            VALUES (@UserId, @BookId, @StartDateTime, @EndDateTime, @CreatedDateTime, @ReturnDateTime, 1)", conn);

                cmdInsert.Parameters.AddWithValue("@UserId", userId);
                cmdInsert.Parameters.AddWithValue("@BookId", bookId);
                cmdInsert.Parameters.AddWithValue("@StartDateTime", now);
                cmdInsert.Parameters.AddWithValue("@EndDateTime", expectedReturn);
                cmdInsert.Parameters.AddWithValue("@CreatedDateTime", now);
                cmdInsert.Parameters.AddWithValue("@ReturnDateTime", now);
                cmdInsert.ExecuteNonQuery();

                // Trả sách trễ?
                if (now > expectedReturn)
                {
                    MessageBox.Show("Trả sách trễ! Vui lòng đóng phí phạt.");
                }

                // Hỏi về tình trạng sách
                DialogResult damageCheck = MessageBox.Show("Sách có bị hư hỏng hoặc mất không?", "Tình trạng sách", MessageBoxButtons.YesNoCancel);

                if (damageCheck == DialogResult.Yes)
                {
                    // Mở form xử lý thiệt hại
                    DamageForm damageForm = new DamageForm();
                    damageForm.ShowDialog();
                }

                // Cập nhật lại số lượng sách
                SqlCommand updateQty = new SqlCommand("UPDATE Books SET AvailableQuantity = AvailableQuantity - 1 WHERE Id = @bookId", conn);
                updateQty.Parameters.AddWithValue("@bookId", bookId);
                updateQty.ExecuteNonQuery();

                MessageBox.Show("Hoàn tất xử lý mượn/trả.");
                LoadBorrowList();  // Hàm hiển thị danh sách mượn vào DataGridView
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
