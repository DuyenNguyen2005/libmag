namespace Library_Management_System
{
    partial class FindBookForm
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
            this.blBookId = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.lbBookSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // blBookId
            // 
            this.blBookId.AutoSize = true;
            this.blBookId.Location = new System.Drawing.Point(36, 117);
            this.blBookId.Name = "blBookId";
            this.blBookId.Size = new System.Drawing.Size(92, 25);
            this.blBookId.TabIndex = 1;
            this.blBookId.Text = "Boook ID";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(36, 178);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(114, 25);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Book Name";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(36, 244);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Category";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(173, 112);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(305, 30);
            this.txtBookId.TabIndex = 4;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(173, 173);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(305, 30);
            this.txtBookName.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(173, 239);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(305, 30);
            this.txtCategory.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(173, 311);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(305, 30);
            this.txtAuthor.TabIndex = 7;
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(36, 316);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(70, 25);
            this.lbAuthorName.TabIndex = 8;
            this.lbAuthorName.Text = "Author";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(41, 376);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 49);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(537, 97);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 62;
            this.dataGridViewSearch.RowTemplate.Height = 28;
            this.dataGridViewSearch.Size = new System.Drawing.Size(363, 328);
            this.dataGridViewSearch.TabIndex = 10;
            // 
            // lbBookSearch
            // 
            this.lbBookSearch.AutoSize = true;
            this.lbBookSearch.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSearch.Location = new System.Drawing.Point(33, 38);
            this.lbBookSearch.Name = "lbBookSearch";
            this.lbBookSearch.Size = new System.Drawing.Size(203, 44);
            this.lbBookSearch.TabIndex = 11;
            this.lbBookSearch.Text = "Book Search";
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(942, 477);
            this.Controls.Add(this.lbBookSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.blBookId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindBookForm";
            this.Text = "Find Book Form";
            this.Load += new System.EventHandler(this.FindBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blBookId;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label lbBookSearch;
    }
}