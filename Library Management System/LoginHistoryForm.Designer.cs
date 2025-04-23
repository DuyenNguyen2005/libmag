namespace Library_Management_System
{
    partial class LoginHistoryForm
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
            this.dataGridViewLoginHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoginHistory
            // 
            this.dataGridViewLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginHistory.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewLoginHistory.Name = "dataGridViewLoginHistory";
            this.dataGridViewLoginHistory.RowHeadersWidth = 62;
            this.dataGridViewLoginHistory.RowTemplate.Height = 28;
            this.dataGridViewLoginHistory.Size = new System.Drawing.Size(1002, 500);
            this.dataGridViewLoginHistory.TabIndex = 0;
            this.dataGridViewLoginHistory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLoginHistory_DataError);
            // 
            // LoginHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dataGridViewLoginHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginHistoryForm";
            this.Text = "LoginHistoryForm";
            this.Load += new System.EventHandler(this.LoginHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoginHistory;
    }
}