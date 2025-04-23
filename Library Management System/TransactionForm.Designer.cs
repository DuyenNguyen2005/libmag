namespace Library_Management_System
{
    partial class TransactionForm
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
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(39, 37);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.RowHeadersWidth = 62;
            this.dataGridViewBorrow.RowTemplate.Height = 28;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(989, 481);
            this.dataGridViewBorrow.TabIndex = 0;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dataGridViewBorrow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionForm";
            this.Text = "Transaction Form";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrow;
    }
}