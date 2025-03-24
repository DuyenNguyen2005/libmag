namespace Library_Management_System
{
    partial class UserManageForm
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
            this.dataGridViewManageUser = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteInfor = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbManageUsers = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageUser)).BeginInit();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewManageUser
            // 
            this.dataGridViewManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageUser.Location = new System.Drawing.Point(584, 130);
            this.dataGridViewManageUser.Name = "dataGridViewManageUser";
            this.dataGridViewManageUser.RowHeadersWidth = 62;
            this.dataGridViewManageUser.RowTemplate.Height = 28;
            this.dataGridViewManageUser.Size = new System.Drawing.Size(447, 378);
            this.dataGridViewManageUser.TabIndex = 37;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(931, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 44);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(816, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 44);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInfor
            // 
            this.btnDeleteInfor.Location = new System.Drawing.Point(695, 54);
            this.btnDeleteInfor.Name = "btnDeleteInfor";
            this.btnDeleteInfor.Size = new System.Drawing.Size(100, 44);
            this.btnDeleteInfor.TabIndex = 33;
            this.btnDeleteInfor.Text = "Delete";
            this.btnDeleteInfor.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(584, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.Location = new System.Drawing.Point(201, 455);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(100, 44);
            this.btnDeleteText.TabIndex = 31;
            this.btnDeleteText.Text = "Delete";
            this.btnDeleteText.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(47, 455);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 44);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(201, 253);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(340, 30);
            this.txtCategory.TabIndex = 27;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(201, 192);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(340, 30);
            this.txtBookName.TabIndex = 26;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(201, 130);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(340, 30);
            this.txtBookId.TabIndex = 25;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(42, 258);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(143, 25);
            this.lbPhone.TabIndex = 22;
            this.lbPhone.Text = "Phone Number";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(42, 197);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 25);
            this.lbUserName.TabIndex = 21;
            this.lbUserName.Text = "Full Name";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(42, 135);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(77, 25);
            this.lbUserId.TabIndex = 20;
            this.lbUserId.Text = "User ID";
            // 
            // lbManageUsers
            // 
            this.lbManageUsers.AutoSize = true;
            this.lbManageUsers.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageUsers.Location = new System.Drawing.Point(39, 54);
            this.lbManageUsers.Name = "lbManageUsers";
            this.lbManageUsers.Size = new System.Drawing.Size(304, 44);
            this.lbManageUsers.TabIndex = 19;
            this.lbManageUsers.Text = "Users Management";
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdbtnFemale);
            this.groupGender.Controls.Add(this.rdbtnMale);
            this.groupGender.Location = new System.Drawing.Point(201, 314);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(340, 110);
            this.groupGender.TabIndex = 38;
            this.groupGender.TabStop = false;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(178, 46);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(102, 29);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(39, 46);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(80, 29);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(42, 323);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(77, 25);
            this.lbGender.TabIndex = 39;
            this.lbGender.Text = "Gender";
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.dataGridViewManageUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteInfor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteText);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.lbManageUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManageForm";
            this.Text = "User Manage Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageUser)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManageUser;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteInfor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbManageUsers;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
    }
}