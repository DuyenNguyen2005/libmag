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
    public partial class LoginHistoryForm: Form
    {
        string connectionString = "Data Source = (localdb)\\ProjectModels;Initial Catalog = \"Library Project\"; Integrated Security = True";
        public LoginHistoryForm()
        {
            InitializeComponent();
        }

        private void LoginHistoryForm_Load(object sender, EventArgs e)
        {
            LoadLoginData();
            dataGridViewLoginHistory.DataError += dataGridViewLoginHistory_DataError;
        }

        private void LoadLoginData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Login";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewLoginHistory.DataSource = table;

                foreach (DataGridViewRow row in dataGridViewLoginHistory.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        object statusValue = row.Cells["Status"].Value;
                        if (statusValue != DBNull.Value && Convert.ToBoolean(statusValue))
                        {
                            row.Cells["Status"].Value = "Online";
                        }
                        else
                        {
                            row.Cells["Status"].Value = "Offline";
                        }
                    }
                }
            }
        }

        private void dataGridViewLoginHistory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
