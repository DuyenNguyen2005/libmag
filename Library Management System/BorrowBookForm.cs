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
    public partial class BorrowBookForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public BorrowBookForm()
        {
            InitializeComponent();
            chkIsTeacher.CheckedChanged += chkIsTeacher_CheckedChanged;
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            LoadBorrowList();
            UpdateExpectedReturnDate();
        }

        private void LoadBorrowList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                b.Id, 
                u.Name AS UserName, 
                bk.Name AS BookName, 
                b.StartDateTime, 
                b.EndDateTime
            FROM Borrow b
            JOIN Users u ON u.Id = b.UserId
            JOIN Books bk ON bk.Id = b.BookId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBorrow.DataSource = dt;
            }
        }

        private void ClearForm()
        {
            txtUserId.Clear();
            txtName.Clear();
            txtNumber.Clear();
            txtBookName.Clear();
            chkIsTeacher.Checked = false;
            UpdateExpectedReturnDate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Tìm BookId và AvailableQuantity
                SqlCommand cmdBook = new SqlCommand("SELECT Id, AvailableQuantity FROM Books WHERE Name = @Name", conn);
                cmdBook.Parameters.AddWithValue("@Name", txtBookName.Text);
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

                // Tìm UserId
                SqlCommand cmdUser = new SqlCommand("SELECT Name, PhoneNumber FROM Users WHERE Id = @UserId", conn);
                cmdUser.Parameters.AddWithValue("@UserId", int.Parse(txtUserId.Text));
                SqlDataReader reader = cmdUser.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Không tìm thấy người dùng.");
                    return;
                }

                txtName.Text = reader["Name"].ToString();
                txtNumber.Text = reader["PhoneNumber"].ToString();
                reader.Close();

                int userId = int.Parse(txtUserId.Text);
                DateTime now = DateTime.Now;
                int borrowDays = chkIsTeacher.Checked ? 15 : 5;
                DateTime expectedReturn = now.AddDays(borrowDays);

                SqlCommand insertCmd = new SqlCommand(@"
            INSERT INTO Borrow (UserId, BookId, StartDateTime, EndDateTime, CreatedDateTime, BorrowStatus) 
            VALUES (@UserId, @BookId, @StartDateTime, @EndDateTime, @CreatedDateTime, 1)", conn);

                insertCmd.Parameters.AddWithValue("@UserId", userId);
                insertCmd.Parameters.AddWithValue("@BookId", bookId);
                insertCmd.Parameters.AddWithValue("@StartDateTime", now);
                insertCmd.Parameters.AddWithValue("@EndDateTime", expectedReturn);
                insertCmd.Parameters.AddWithValue("@CreatedDateTime", now);
                insertCmd.ExecuteNonQuery();

                // Giảm số lượng sách
                SqlCommand updateBook = new SqlCommand("UPDATE Books SET AvailableQuantity = AvailableQuantity - 1 WHERE Id = @BookId", conn);
                updateBook.Parameters.AddWithValue("@BookId", bookId);
                updateBook.ExecuteNonQuery();

                MessageBox.Show("Mượn sách thành công!");
                LoadBorrowList();
                ClearForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateExpectedReturnDate()
        {
            int borrowDays = chkIsTeacher.Checked ? 15 : 5;
            dtpExpectedDate.Value = DateTime.Now.AddDays(borrowDays);
        }

        private void chkIsTeacher_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedReturnDate();
        }
    }
}
