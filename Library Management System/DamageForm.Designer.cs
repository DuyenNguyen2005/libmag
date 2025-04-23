namespace Library_Management_System
{
    partial class DamageForm
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
            this.lbDamageReport = new System.Windows.Forms.Label();
            this.lbBookId = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbDamageType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataGridViewDamageReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDamageReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDamageReport
            // 
            this.lbDamageReport.AutoSize = true;
            this.lbDamageReport.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDamageReport.Location = new System.Drawing.Point(46, 57);
            this.lbDamageReport.Name = "lbDamageReport";
            this.lbDamageReport.Size = new System.Drawing.Size(245, 44);
            this.lbDamageReport.TabIndex = 0;
            this.lbDamageReport.Text = "Damage Report";
            // 
            // lbBookId
            // 
            this.lbBookId.AutoSize = true;
            this.lbBookId.Location = new System.Drawing.Point(49, 142);
            this.lbBookId.Name = "lbBookId";
            this.lbBookId.Size = new System.Drawing.Size(81, 25);
            this.lbBookId.TabIndex = 1;
            this.lbBookId.Text = "Book ID";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(49, 197);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 2;
            this.lbUserId.Text = "User ID";
            // 
            // lbDamageType
            // 
            this.lbDamageType.AutoSize = true;
            this.lbDamageType.Location = new System.Drawing.Point(49, 254);
            this.lbDamageType.Name = "lbDamageType";
            this.lbDamageType.Size = new System.Drawing.Size(136, 25);
            this.lbDamageType.TabIndex = 3;
            this.lbDamageType.Text = "Damage Type";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(49, 319);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(109, 25);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "Description";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(213, 137);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(361, 30);
            this.txtBookId.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(213, 192);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(361, 30);
            this.txtUserId.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 316);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(361, 96);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(213, 251);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(361, 33);
            this.cbType.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(54, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(213, 440);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 55);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataGridViewDamageReport
            // 
            this.dataGridViewDamageReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDamageReport.Location = new System.Drawing.Point(647, 57);
            this.dataGridViewDamageReport.Name = "dataGridViewDamageReport";
            this.dataGridViewDamageReport.RowHeadersWidth = 62;
            this.dataGridViewDamageReport.RowTemplate.Height = 28;
            this.dataGridViewDamageReport.Size = new System.Drawing.Size(343, 438);
            this.dataGridViewDamageReport.TabIndex = 11;
            // 
            // DamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dataGridViewDamageReport);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDamageType);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.lbBookId);
            this.Controls.Add(this.lbDamageReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DamageForm";
            this.Text = "Damage Form";
            this.Load += new System.EventHandler(this.DamageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDamageReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDamageReport;
        private System.Windows.Forms.Label lbBookId;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbDamageType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridViewDamageReport;
    }
}