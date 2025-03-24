using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UserForm: Form
    {
        public UserForm()
        {
            InitializeComponent();
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
    }
}
