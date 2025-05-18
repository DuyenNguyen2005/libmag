namespace Library_Management_System
{
    partial class EmployeeManageForm
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
            this.gpContact = new System.Windows.Forms.GroupBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployeeID = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbEnterID = new System.Windows.Forms.Label();
            this.btnShowFullList = new System.Windows.Forms.Button();
            this.btnEditEmploee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gpContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpContact
            // 
            this.gpContact.Controls.Add(this.btnSelectEmployee);
            this.gpContact.Controls.Add(this.btnRemoveEmployeeID);
            this.gpContact.Controls.Add(this.txtEmployeeID);
            this.gpContact.Controls.Add(this.lbEnterID);
            this.gpContact.Location = new System.Drawing.Point(51, 348);
            this.gpContact.Margin = new System.Windows.Forms.Padding(4);
            this.gpContact.Name = "gpContact";
            this.gpContact.Padding = new System.Windows.Forms.Padding(4);
            this.gpContact.Size = new System.Drawing.Size(665, 212);
            this.gpContact.TabIndex = 11;
            this.gpContact.TabStop = false;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(420, 54);
            this.btnSelectEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(232, 44);
            this.btnSelectEmployee.TabIndex = 3;
            this.btnSelectEmployee.Text = "Select Employee";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            this.btnSelectEmployee.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // btnRemoveEmployeeID
            // 
            this.btnRemoveEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployeeID.Location = new System.Drawing.Point(15, 134);
            this.btnRemoveEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveEmployeeID.Name = "btnRemoveEmployeeID";
            this.btnRemoveEmployeeID.Size = new System.Drawing.Size(637, 55);
            this.btnRemoveEmployeeID.TabIndex = 2;
            this.btnRemoveEmployeeID.Text = "Remove";
            this.btnRemoveEmployeeID.UseVisualStyleBackColor = true;
            this.btnRemoveEmployeeID.Click += new System.EventHandler(this.btnRemoveEmployeeID_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(198, 60);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(214, 32);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lbEnterID
            // 
            this.lbEnterID.AutoSize = true;
            this.lbEnterID.Location = new System.Drawing.Point(10, 64);
            this.lbEnterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnterID.Name = "lbEnterID";
            this.lbEnterID.Size = new System.Drawing.Size(180, 25);
            this.lbEnterID.TabIndex = 0;
            this.lbEnterID.Text = "Enter Employee ID:";
            // 
            // btnShowFullList
            // 
            this.btnShowFullList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFullList.Location = new System.Drawing.Point(51, 602);
            this.btnShowFullList.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFullList.Name = "btnShowFullList";
            this.btnShowFullList.Size = new System.Drawing.Size(665, 55);
            this.btnShowFullList.TabIndex = 10;
            this.btnShowFullList.Text = "Show Full List";
            this.btnShowFullList.UseVisualStyleBackColor = true;
            this.btnShowFullList.Click += new System.EventHandler(this.btnShowFullList_Click);
            // 
            // btnEditEmploee
            // 
            this.btnEditEmploee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmploee.Location = new System.Drawing.Point(51, 241);
            this.btnEditEmploee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmploee.Name = "btnEditEmploee";
            this.btnEditEmploee.Size = new System.Drawing.Size(264, 79);
            this.btnEditEmploee.TabIndex = 9;
            this.btnEditEmploee.Text = "Edit";
            this.btnEditEmploee.UseVisualStyleBackColor = true;
            this.btnEditEmploee.Click += new System.EventHandler(this.btnEditEmploee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(51, 128);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(264, 79);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(40, 38);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(361, 44);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Employee Management";
            // 
            // EmployeeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 725);
            this.Controls.Add(this.gpContact);
            this.Controls.Add(this.btnShowFullList);
            this.Controls.Add(this.btnEditEmploee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManageForm";
            this.Text = "EmployeeManageForm";
            this.Load += new System.EventHandler(this.EmployeeManageForm_Load);
            this.gpContact.ResumeLayout(false);
            this.gpContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpContact;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.Button btnRemoveEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lbEnterID;
        private System.Windows.Forms.Button btnShowFullList;
        private System.Windows.Forms.Button btnEditEmploee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lbTitle;
    }
}