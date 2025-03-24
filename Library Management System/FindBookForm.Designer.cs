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
            this.txtBookGenre = new System.Windows.Forms.TextBox();
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
            this.blBookId.Location = new System.Drawing.Point(60, 121);
            this.blBookId.Name = "blBookId";
            this.blBookId.Size = new System.Drawing.Size(31, 25);
            this.blBookId.TabIndex = 1;
            this.blBookId.Text = "ID";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(60, 180);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(64, 25);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Name";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(60, 243);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Category";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(171, 116);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(305, 30);
            this.txtBookId.TabIndex = 4;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(171, 175);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(305, 30);
            this.txtBookName.TabIndex = 5;
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Location = new System.Drawing.Point(171, 238);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(305, 30);
            this.txtBookGenre.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(171, 302);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(305, 30);
            this.txtAuthor.TabIndex = 7;
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(60, 305);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(70, 25);
            this.lbAuthorName.TabIndex = 8;
            this.lbAuthorName.Text = "Author";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(65, 372);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 49);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(552, 37);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 62;
            this.dataGridViewSearch.RowTemplate.Height = 28;
            this.dataGridViewSearch.Size = new System.Drawing.Size(328, 384);
            this.dataGridViewSearch.TabIndex = 10;
            // 
            // lbBookSearch
            // 
            this.lbBookSearch.AutoSize = true;
            this.lbBookSearch.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSearch.Location = new System.Drawing.Point(57, 37);
            this.lbBookSearch.Name = "lbBookSearch";
            this.lbBookSearch.Size = new System.Drawing.Size(203, 44);
            this.lbBookSearch.TabIndex = 11;
            this.lbBookSearch.Text = "Book Search";
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 500);
            this.Controls.Add(this.lbBookSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookGenre);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.blBookId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindBookForm";
            this.Text = "Find Book Form";
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
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label lbBookSearch;
    }
}