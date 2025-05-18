namespace Library_Management_System
{
    partial class BorrowBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBorrowBook = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPhone = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkIsTeacher = new System.Windows.Forms.CheckBox();
            this.lbExpectedReturnDate = new System.Windows.Forms.Label();
            this.dtpExpectedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBorrowBook
            // 
            this.lbBorrowBook.AutoSize = true;
            this.lbBorrowBook.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowBook.Location = new System.Drawing.Point(28, 45);
            this.lbBorrowBook.Name = "lbBorrowBook";
            this.lbBorrowBook.Size = new System.Drawing.Size(203, 44);
            this.lbBorrowBook.TabIndex = 0;
            this.lbBorrowBook.Text = "Borrow Book";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(31, 131);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 1;
            this.lbUserId.Text = "User ID";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(31, 187);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 25);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Full Name";
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.Location = new System.Drawing.Point(31, 241);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(143, 25);
            this.lbUserPhone.TabIndex = 3;
            this.lbUserPhone.Text = "Phone Number";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(31, 298);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(114, 25);
            this.lbBookName.TabIndex = 4;
            this.lbBookName.Text = "Book Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(191, 126);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(391, 30);
            this.txtUserId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(191, 241);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(391, 30);
            this.txtNumber.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(191, 298);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(391, 30);
            this.txtBookName.TabIndex = 8;
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(613, 45);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.RowHeadersWidth = 62;
            this.dataGridViewBorrow.RowTemplate.Height = 28;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(590, 426);
            this.dataGridViewBorrow.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(36, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(174, 423);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 48);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkIsTeacher
            // 
            this.chkIsTeacher.AutoSize = true;
            this.chkIsTeacher.Location = new System.Drawing.Point(324, 434);
            this.chkIsTeacher.Name = "chkIsTeacher";
            this.chkIsTeacher.Size = new System.Drawing.Size(111, 29);
            this.chkIsTeacher.TabIndex = 12;
            this.chkIsTeacher.Text = "Teacher";
            this.chkIsTeacher.UseVisualStyleBackColor = true;
            this.chkIsTeacher.CheckedChanged += new System.EventHandler(this.chkIsTeacher_CheckedChanged);
            // 
            // lbExpectedReturnDate
            // 
            this.lbExpectedReturnDate.AutoSize = true;
            this.lbExpectedReturnDate.Location = new System.Drawing.Point(31, 357);
            this.lbExpectedReturnDate.Name = "lbExpectedReturnDate";
            this.lbExpectedReturnDate.Size = new System.Drawing.Size(202, 25);
            this.lbExpectedReturnDate.TabIndex = 13;
            this.lbExpectedReturnDate.Text = "Expected Return Date";
            // 
            // dtpExpectedDate
            // 
            this.dtpExpectedDate.Location = new System.Drawing.Point(254, 357);
            this.dtpExpectedDate.Name = "dtpExpectedDate";
            this.dtpExpectedDate.Size = new System.Drawing.Size(328, 30);
            this.dtpExpectedDate.TabIndex = 14;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.dtpExpectedDate);
            this.Controls.Add(this.lbExpectedReturnDate);
            this.Controls.Add(this.chkIsTeacher);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewBorrow);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbUserPhone);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.lbBorrowBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BorrowBookForm";
            this.Text = "Borrow Book Form";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBorrowBook;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPhone;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DataGridView dataGridViewBorrow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkIsTeacher;
        private System.Windows.Forms.Label lbExpectedReturnDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedDate;
    }
}