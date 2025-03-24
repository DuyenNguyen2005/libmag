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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBorrowBook
            // 
            this.lbBorrowBook.AutoSize = true;
            this.lbBorrowBook.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowBook.Location = new System.Drawing.Point(38, 46);
            this.lbBorrowBook.Name = "lbBorrowBook";
            this.lbBorrowBook.Size = new System.Drawing.Size(203, 44);
            this.lbBorrowBook.TabIndex = 0;
            this.lbBorrowBook.Text = "Borrow Book";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(41, 132);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 1;
            this.lbUserId.Text = "User ID";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(41, 206);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 25);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Full Name";
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.Location = new System.Drawing.Point(41, 281);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(143, 25);
            this.lbUserPhone.TabIndex = 3;
            this.lbUserPhone.Text = "Phone Number";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(41, 356);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(114, 25);
            this.lbBookName.TabIndex = 4;
            this.lbBookName.Text = "Book Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(201, 127);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(281, 30);
            this.txtUserId.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(201, 201);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(281, 30);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(201, 276);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(281, 30);
            this.txtUserPhone.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(201, 351);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(281, 30);
            this.txtBookName.TabIndex = 8;
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(550, 46);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.RowHeadersWidth = 62;
            this.dataGridViewBorrow.RowTemplate.Height = 28;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(369, 427);
            this.dataGridViewBorrow.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(85, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(296, 425);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 48);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(964, 529);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewBorrow);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserName);
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
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DataGridView dataGridViewBorrow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}