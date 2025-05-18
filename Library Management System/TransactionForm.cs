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
    public partial class TransactionForm: Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadBorrowData();
        }

        private void LoadBorrowData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=\"Library Project\";Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    conn.Open();

                    // Câu lệnh SQL để lấy toàn bộ dữ liệu từ bảng Borrow
                    string query = @"SELECT Id, UserId, BookId, StartDateTime, EndDateTime, 
                                CreatedDateTime, BorrowStatus, ReturnDateTime, Note 
                                FROM Borrow";

                    // Sử dụng SqlDataAdapter để lấy dữ liệu
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(table);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridViewBorrow.DataSource = table;



                    // (Tùy chọn) Tùy chỉnh hiển thị cột
                    dataGridViewBorrow.Columns["Id"].HeaderText = "Mã mượn";
                    dataGridViewBorrow.Columns["UserId"].HeaderText = "Mã người dùng";
                    dataGridViewBorrow.Columns["BookId"].HeaderText = "Mã sách";
                    dataGridViewBorrow.Columns["StartDateTime"].HeaderText = "Ngày mượn";
                    dataGridViewBorrow.Columns["EndDateTime"].HeaderText = "Dự kiến trả";
                    dataGridViewBorrow.Columns["CreatedDateTime"].HeaderText = "Ngày tạo";
                    dataGridViewBorrow.Columns["BorrowStatus"].HeaderText = "Trạng thái";
                    dataGridViewBorrow.Columns["ReturnDateTime"].HeaderText = "Ngày trả";
                    dataGridViewBorrow.Columns["Note"].HeaderText = "Ghi chú";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
