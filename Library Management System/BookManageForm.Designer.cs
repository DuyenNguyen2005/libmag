namespace Library_Management_System
{
    partial class BookManageForm
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
            this.lbManageBooks = new System.Windows.Forms.Label();
            this.lbBookId = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteInfor = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkBorrowed = new System.Windows.Forms.CheckBox();
            this.dataGridViewManageBook = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageBooks
            // 
            this.lbManageBooks.AutoSize = true;
            this.lbManageBooks.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageBooks.Location = new System.Drawing.Point(43, 41);
            this.lbManageBooks.Name = "lbManageBooks";
            this.lbManageBooks.Size = new System.Drawing.Size(309, 44);
            this.lbManageBooks.TabIndex = 0;
            this.lbManageBooks.Text = "Books Management";
            // 
            // lbBookId
            // 
            this.lbBookId.AutoSize = true;
            this.lbBookId.Location = new System.Drawing.Point(46, 122);
            this.lbBookId.Name = "lbBookId";
            this.lbBookId.Size = new System.Drawing.Size(81, 25);
            this.lbBookId.TabIndex = 1;
            this.lbBookId.Text = "Book ID";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(46, 184);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(114, 25);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Book Name";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(46, 245);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Category";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(46, 310);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(70, 25);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "Author";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(46, 376);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(85, 25);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(190, 117);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(337, 30);
            this.txtBookId.TabIndex = 6;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(190, 179);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(337, 30);
            this.txtBookName.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(190, 240);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(337, 30);
            this.txtCategory.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(190, 305);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(337, 30);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(190, 371);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(337, 30);
            this.txtQuantity.TabIndex = 10;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(891, 47);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 44);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteInfor
            // 
            this.btnDeleteInfor.Location = new System.Drawing.Point(679, 47);
            this.btnDeleteInfor.Name = "btnDeleteInfor";
            this.btnDeleteInfor.Size = new System.Drawing.Size(100, 44);
            this.btnDeleteInfor.TabIndex = 14;
            this.btnDeleteInfor.Text = "Delete";
            this.btnDeleteInfor.UseVisualStyleBackColor = true;
            this.btnDeleteInfor.Click += new System.EventHandler(this.btnDeleteInfor_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(785, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 44);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkBorrowed
            // 
            this.chkBorrowed.AutoSize = true;
            this.chkBorrowed.Location = new System.Drawing.Point(190, 448);
            this.chkBorrowed.Name = "chkBorrowed";
            this.chkBorrowed.Size = new System.Drawing.Size(121, 29);
            this.chkBorrowed.TabIndex = 17;
            this.chkBorrowed.Text = "Borrowed";
            this.chkBorrowed.UseVisualStyleBackColor = true;
            // 
            // dataGridViewManageBook
            // 
            this.dataGridViewManageBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageBook.Location = new System.Drawing.Point(573, 105);
            this.dataGridViewManageBook.Name = "dataGridViewManageBook";
            this.dataGridViewManageBook.RowHeadersWidth = 62;
            this.dataGridViewManageBook.RowTemplate.Height = 28;
            this.dataGridViewManageBook.Size = new System.Drawing.Size(418, 378);
            this.dataGridViewManageBook.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(51, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 44);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1059, 537);
            this.Controls.Add(this.dataGridViewManageBook);
            this.Controls.Add(this.chkBorrowed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteInfor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbBookId);
            this.Controls.Add(this.lbManageBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookManageForm";
            this.Text = "Book Manage Form";
            this.Load += new System.EventHandler(this.BookManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManageBooks;
        private System.Windows.Forms.Label lbBookId;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteInfor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkBorrowed;
        private System.Windows.Forms.DataGridView dataGridViewManageBook;
        private System.Windows.Forms.Button btnReset;
    }
}