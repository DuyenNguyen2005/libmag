namespace Library_Management_System
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbReport = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbBookCategory = new System.Windows.Forms.Label();
            this.lbBookQuantity = new System.Windows.Forms.Label();
            this.lbBorrowingFrequency = new System.Windows.Forms.Label();
            this.lbActiveUsers = new System.Windows.Forms.Label();
            this.lbBookCondition = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.chartBooksByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBorrowFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartActiveUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBookCondition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooksByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrowFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReport.Location = new System.Drawing.Point(310, 32);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(328, 44);
            this.lbReport.TabIndex = 0;
            this.lbReport.Text = "Report and Statistics";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(6, 31);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(109, 25);
            this.lbFromDate.TabIndex = 1;
            this.lbFromDate.Text = "From Date:";
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(6, 80);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(88, 25);
            this.lbToDate.TabIndex = 2;
            this.lbToDate.Text = "To Date:";
            // 
            // lbBookCategory
            // 
            this.lbBookCategory.AutoSize = true;
            this.lbBookCategory.Location = new System.Drawing.Point(476, 26);
            this.lbBookCategory.Name = "lbBookCategory";
            this.lbBookCategory.Size = new System.Drawing.Size(148, 25);
            this.lbBookCategory.TabIndex = 3;
            this.lbBookCategory.Text = "Book Category:";
            // 
            // lbBookQuantity
            // 
            this.lbBookQuantity.AutoSize = true;
            this.lbBookQuantity.Location = new System.Drawing.Point(9, 224);
            this.lbBookQuantity.Name = "lbBookQuantity";
            this.lbBookQuantity.Size = new System.Drawing.Size(303, 25);
            this.lbBookQuantity.TabIndex = 4;
            this.lbBookQuantity.Text = "The number of books by category";
            // 
            // lbBorrowingFrequency
            // 
            this.lbBorrowingFrequency.AutoSize = true;
            this.lbBorrowingFrequency.Location = new System.Drawing.Point(510, 224);
            this.lbBorrowingFrequency.Name = "lbBorrowingFrequency";
            this.lbBorrowingFrequency.Size = new System.Drawing.Size(274, 25);
            this.lbBorrowingFrequency.TabIndex = 5;
            this.lbBorrowingFrequency.Text = "Borrowing frequency over time";
            // 
            // lbActiveUsers
            // 
            this.lbActiveUsers.AutoSize = true;
            this.lbActiveUsers.Location = new System.Drawing.Point(9, 623);
            this.lbActiveUsers.Name = "lbActiveUsers";
            this.lbActiveUsers.Size = new System.Drawing.Size(446, 25);
            this.lbActiveUsers.TabIndex = 6;
            this.lbActiveUsers.Text = "List of active users (highest number of borrowings)";
            // 
            // lbBookCondition
            // 
            this.lbBookCondition.AutoSize = true;
            this.lbBookCondition.Location = new System.Drawing.Point(510, 623);
            this.lbBookCondition.Name = "lbBookCondition";
            this.lbBookCondition.Size = new System.Drawing.Size(145, 25);
            this.lbBookCondition.TabIndex = 7;
            this.lbBookCondition.Text = "Book Condition";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnOk);
            this.grpFilter.Controls.Add(this.btnExport);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.cbCategory);
            this.grpFilter.Controls.Add(this.dtpTo);
            this.grpFilter.Controls.Add(this.dtpFrom);
            this.grpFilter.Controls.Add(this.lbFromDate);
            this.grpFilter.Controls.Add(this.lbToDate);
            this.grpFilter.Controls.Add(this.lbBookCategory);
            this.grpFilter.Location = new System.Drawing.Point(14, 89);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(930, 121);
            this.grpFilter.TabIndex = 8;
            this.grpFilter.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(630, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 37);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(481, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(630, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(285, 33);
            this.cbCategory.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(122, 75);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(324, 30);
            this.dtpTo.TabIndex = 5;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(122, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(324, 30);
            this.dtpFrom.TabIndex = 4;
            // 
            // chartBooksByCategory
            // 
            chartArea9.Name = "ChartArea1";
            this.chartBooksByCategory.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartBooksByCategory.Legends.Add(legend9);
            this.chartBooksByCategory.Location = new System.Drawing.Point(14, 269);
            this.chartBooksByCategory.Name = "chartBooksByCategory";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartBooksByCategory.Series.Add(series9);
            this.chartBooksByCategory.Size = new System.Drawing.Size(429, 319);
            this.chartBooksByCategory.TabIndex = 9;
            this.chartBooksByCategory.Text = "chartBooksByCategory";
            // 
            // chartBorrowFrequency
            // 
            chartArea10.Name = "ChartArea1";
            this.chartBorrowFrequency.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartBorrowFrequency.Legends.Add(legend10);
            this.chartBorrowFrequency.Location = new System.Drawing.Point(515, 269);
            this.chartBorrowFrequency.Name = "chartBorrowFrequency";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartBorrowFrequency.Series.Add(series10);
            this.chartBorrowFrequency.Size = new System.Drawing.Size(429, 319);
            this.chartBorrowFrequency.TabIndex = 10;
            this.chartBorrowFrequency.Text = "chartBorrowFrequency";
            // 
            // chartActiveUsers
            // 
            chartArea11.Name = "ChartArea1";
            this.chartActiveUsers.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartActiveUsers.Legends.Add(legend11);
            this.chartActiveUsers.Location = new System.Drawing.Point(14, 668);
            this.chartActiveUsers.Name = "chartActiveUsers";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartActiveUsers.Series.Add(series11);
            this.chartActiveUsers.Size = new System.Drawing.Size(429, 319);
            this.chartActiveUsers.TabIndex = 11;
            this.chartActiveUsers.Text = "chart3";
            // 
            // chartBookCondition
            // 
            chartArea12.Name = "ChartArea1";
            this.chartBookCondition.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartBookCondition.Legends.Add(legend12);
            this.chartBookCondition.Location = new System.Drawing.Point(515, 668);
            this.chartBookCondition.Name = "chartBookCondition";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartBookCondition.Series.Add(series12);
            this.chartBookCondition.Size = new System.Drawing.Size(429, 319);
            this.chartBookCondition.TabIndex = 12;
            this.chartBookCondition.Text = "chart4";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(775, 68);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 37);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 1046);
            this.Controls.Add(this.chartBookCondition);
            this.Controls.Add(this.chartActiveUsers);
            this.Controls.Add(this.chartBorrowFrequency);
            this.Controls.Add(this.chartBooksByCategory);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lbBookCondition);
            this.Controls.Add(this.lbActiveUsers);
            this.Controls.Add(this.lbBorrowingFrequency);
            this.Controls.Add(this.lbBookQuantity);
            this.Controls.Add(this.lbReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooksByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrowFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookCondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbBookCategory;
        private System.Windows.Forms.Label lbBookQuantity;
        private System.Windows.Forms.Label lbBorrowingFrequency;
        private System.Windows.Forms.Label lbActiveUsers;
        private System.Windows.Forms.Label lbBookCondition;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooksByCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBorrowFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActiveUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookCondition;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOk;
    }
}