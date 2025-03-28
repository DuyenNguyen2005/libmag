namespace Library_Management_System
{
    partial class BorrowReturnManageForm
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
            this.lbBookTransactions = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbBookId = new System.Windows.Forms.Label();
            this.lbBorrowDate = new System.Windows.Forms.Label();
            this.lbExpected = new System.Windows.Forms.Label();
            this.lbActual = new System.Windows.Forms.Label();
            this.lbFineAmount = new System.Windows.Forms.Label();
            this.dataGridViewBookTransactions = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpected = new System.Windows.Forms.DateTimePicker();
            this.dtpActual = new System.Windows.Forms.DateTimePicker();
            this.lbFine = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBookTransactions
            // 
            this.lbBookTransactions.AutoSize = true;
            this.lbBookTransactions.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTransactions.Location = new System.Drawing.Point(45, 48);
            this.lbBookTransactions.Name = "lbBookTransactions";
            this.lbBookTransactions.Size = new System.Drawing.Size(493, 44);
            this.lbBookTransactions.TabIndex = 0;
            this.lbBookTransactions.Text = "Book Transactions Management";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(48, 139);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 1;
            this.lbUserId.Text = "User ID";
            // 
            // lbBookId
            // 
            this.lbBookId.AutoSize = true;
            this.lbBookId.Location = new System.Drawing.Point(48, 199);
            this.lbBookId.Name = "lbBookId";
            this.lbBookId.Size = new System.Drawing.Size(81, 25);
            this.lbBookId.TabIndex = 2;
            this.lbBookId.Text = "Book ID";
            // 
            // lbBorrowDate
            // 
            this.lbBorrowDate.AutoSize = true;
            this.lbBorrowDate.Location = new System.Drawing.Point(48, 255);
            this.lbBorrowDate.Name = "lbBorrowDate";
            this.lbBorrowDate.Size = new System.Drawing.Size(119, 25);
            this.lbBorrowDate.TabIndex = 3;
            this.lbBorrowDate.Text = "Borrow Date";
            // 
            // lbExpected
            // 
            this.lbExpected.AutoSize = true;
            this.lbExpected.Location = new System.Drawing.Point(48, 311);
            this.lbExpected.Name = "lbExpected";
            this.lbExpected.Size = new System.Drawing.Size(202, 25);
            this.lbExpected.TabIndex = 4;
            this.lbExpected.Text = "Expected Return Date\r\n";
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Location = new System.Drawing.Point(48, 366);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(175, 25);
            this.lbActual.TabIndex = 5;
            this.lbActual.Text = "Actual Return Date";
            // 
            // lbFineAmount
            // 
            this.lbFineAmount.AutoSize = true;
            this.lbFineAmount.Location = new System.Drawing.Point(48, 422);
            this.lbFineAmount.Name = "lbFineAmount";
            this.lbFineAmount.Size = new System.Drawing.Size(129, 25);
            this.lbFineAmount.TabIndex = 6;
            this.lbFineAmount.Text = "Fine Amount:";
            // 
            // dataGridViewBookTransactions
            // 
            this.dataGridViewBookTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookTransactions.Location = new System.Drawing.Point(660, 48);
            this.dataGridViewBookTransactions.Name = "dataGridViewBookTransactions";
            this.dataGridViewBookTransactions.RowHeadersWidth = 62;
            this.dataGridViewBookTransactions.RowTemplate.Height = 28;
            this.dataGridViewBookTransactions.Size = new System.Drawing.Size(331, 399);
            this.dataGridViewBookTransactions.TabIndex = 8;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(277, 139);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(337, 30);
            this.txtUserId.TabIndex = 9;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(277, 199);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(337, 30);
            this.txtBookId.TabIndex = 10;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(277, 255);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(337, 30);
            this.dtpBorrowDate.TabIndex = 11;
            // 
            // dtpExpected
            // 
            this.dtpExpected.Location = new System.Drawing.Point(277, 311);
            this.dtpExpected.Name = "dtpExpected";
            this.dtpExpected.Size = new System.Drawing.Size(337, 30);
            this.dtpExpected.TabIndex = 12;
            // 
            // dtpActual
            // 
            this.dtpActual.Location = new System.Drawing.Point(277, 366);
            this.dtpActual.Name = "dtpActual";
            this.dtpActual.Size = new System.Drawing.Size(337, 30);
            this.dtpActual.TabIndex = 13;
            // 
            // lbFine
            // 
            this.lbFine.AutoSize = true;
            this.lbFine.Location = new System.Drawing.Point(272, 422);
            this.lbFine.Name = "lbFine";
            this.lbFine.Size = new System.Drawing.Size(0, 25);
            this.lbFine.TabIndex = 14;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(245, 476);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 45);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // BorrowReturnManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbFine);
            this.Controls.Add(this.dtpActual);
            this.Controls.Add(this.dtpExpected);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.dataGridViewBookTransactions);
            this.Controls.Add(this.lbFineAmount);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.lbExpected);
            this.Controls.Add(this.lbBorrowDate);
            this.Controls.Add(this.lbBookId);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.lbBookTransactions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BorrowReturnManageForm";
            this.Text = "Borrow/Return Manage Form";
            this.Load += new System.EventHandler(this.BorrowReturnManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookTransactions;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbBookId;
        private System.Windows.Forms.Label lbBorrowDate;
        private System.Windows.Forms.Label lbExpected;
        private System.Windows.Forms.Label lbActual;
        private System.Windows.Forms.Label lbFineAmount;
        private System.Windows.Forms.DataGridView dataGridViewBookTransactions;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpExpected;
        private System.Windows.Forms.DateTimePicker dtpActual;
        private System.Windows.Forms.Label lbFine;
        private System.Windows.Forms.Button btnFind;
    }
}