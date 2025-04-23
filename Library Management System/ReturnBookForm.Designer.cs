namespace Library_Management_System
{
    partial class ReturnBookForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbUserPhone = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbReturnBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(192, 355);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 48);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(50, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(554, 51);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.RowHeadersWidth = 62;
            this.dataGridViewReturn.RowTemplate.Height = 28;
            this.dataGridViewReturn.Size = new System.Drawing.Size(369, 352);
            this.dataGridViewReturn.TabIndex = 21;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(205, 289);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(281, 30);
            this.txtBookName.TabIndex = 20;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(205, 228);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(281, 30);
            this.txtNumber.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(205, 170);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 30);
            this.txtName.TabIndex = 18;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(205, 115);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(281, 30);
            this.txtUserId.TabIndex = 17;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(45, 294);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(114, 25);
            this.lbBookName.TabIndex = 16;
            this.lbBookName.Text = "Book Name";
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.Location = new System.Drawing.Point(45, 233);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(143, 25);
            this.lbUserPhone.TabIndex = 15;
            this.lbUserPhone.Text = "Phone Number";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(45, 175);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 25);
            this.lbUserName.TabIndex = 14;
            this.lbUserName.Text = "Full Name";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(45, 120);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 13;
            this.lbUserId.Text = "User ID";
            // 
            // lbReturnBook
            // 
            this.lbReturnBook.AutoSize = true;
            this.lbReturnBook.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnBook.Location = new System.Drawing.Point(42, 51);
            this.lbReturnBook.Name = "lbReturnBook";
            this.lbReturnBook.Size = new System.Drawing.Size(197, 44);
            this.lbReturnBook.TabIndex = 12;
            this.lbReturnBook.Text = "Return Book";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(964, 439);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewReturn);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbUserPhone);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.lbReturnBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnBookForm";
            this.Text = "Return Book Form";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbUserPhone;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbReturnBook;
    }
}