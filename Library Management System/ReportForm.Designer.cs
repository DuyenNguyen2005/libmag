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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbReport = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbBookCategory = new System.Windows.Forms.Label();
            this.lbBookQuantity = new System.Windows.Forms.Label();
            this.lbBorrowingFrequency = new System.Windows.Forms.Label();
            this.lbActiveUsers = new System.Windows.Forms.Label();
            this.lbBookCondition = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chartBookQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBorrowingFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartActiveUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBookCondition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrowingFrequency)).BeginInit();
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
            this.lbBookQuantity.Location = new System.Drawing.Point(9, 237);
            this.lbBookQuantity.Name = "lbBookQuantity";
            this.lbBookQuantity.Size = new System.Drawing.Size(303, 25);
            this.lbBookQuantity.TabIndex = 4;
            this.lbBookQuantity.Text = "The number of books by category";
            // 
            // lbBorrowingFrequency
            // 
            this.lbBorrowingFrequency.AutoSize = true;
            this.lbBorrowingFrequency.Location = new System.Drawing.Point(510, 237);
            this.lbBorrowingFrequency.Name = "lbBorrowingFrequency";
            this.lbBorrowingFrequency.Size = new System.Drawing.Size(274, 25);
            this.lbBorrowingFrequency.TabIndex = 5;
            this.lbBorrowingFrequency.Text = "Borrowing frequency over time";
            // 
            // lbActiveUsers
            // 
            this.lbActiveUsers.AutoSize = true;
            this.lbActiveUsers.Location = new System.Drawing.Point(9, 636);
            this.lbActiveUsers.Name = "lbActiveUsers";
            this.lbActiveUsers.Size = new System.Drawing.Size(446, 25);
            this.lbActiveUsers.TabIndex = 6;
            this.lbActiveUsers.Text = "List of active users (highest number of borrowings)";
            // 
            // lbBookCondition
            // 
            this.lbBookCondition.AutoSize = true;
            this.lbBookCondition.Location = new System.Drawing.Point(510, 636);
            this.lbBookCondition.Name = "lbBookCondition";
            this.lbBookCondition.Size = new System.Drawing.Size(145, 25);
            this.lbBookCondition.TabIndex = 7;
            this.lbBookCondition.Text = "Book Condition";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnExport);
            this.grpFilter.Controls.Add(this.btnCancel);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.cbBookCategory);
            this.grpFilter.Controls.Add(this.dtpToDate);
            this.grpFilter.Controls.Add(this.dtpFromDate);
            this.grpFilter.Controls.Add(this.lbFromDate);
            this.grpFilter.Controls.Add(this.lbToDate);
            this.grpFilter.Controls.Add(this.lbBookCategory);
            this.grpFilter.Location = new System.Drawing.Point(14, 99);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(930, 121);
            this.grpFilter.TabIndex = 8;
            this.grpFilter.TabStop = false;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(122, 26);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(324, 30);
            this.dtpFromDate.TabIndex = 4;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(122, 75);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(324, 30);
            this.dtpToDate.TabIndex = 5;
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(630, 23);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(285, 33);
            this.cbBookCategory.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(776, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // chartBookQuantity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBookQuantity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBookQuantity.Legends.Add(legend1);
            this.chartBookQuantity.Location = new System.Drawing.Point(14, 282);
            this.chartBookQuantity.Name = "chartBookQuantity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBookQuantity.Series.Add(series1);
            this.chartBookQuantity.Size = new System.Drawing.Size(429, 319);
            this.chartBookQuantity.TabIndex = 9;
            this.chartBookQuantity.Text = "chart1";
            // 
            // chartBorrowingFrequency
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBorrowingFrequency.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBorrowingFrequency.Legends.Add(legend2);
            this.chartBorrowingFrequency.Location = new System.Drawing.Point(515, 282);
            this.chartBorrowingFrequency.Name = "chartBorrowingFrequency";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBorrowingFrequency.Series.Add(series2);
            this.chartBorrowingFrequency.Size = new System.Drawing.Size(429, 319);
            this.chartBorrowingFrequency.TabIndex = 10;
            this.chartBorrowingFrequency.Text = "chart2";
            // 
            // chartActiveUsers
            // 
            chartArea3.Name = "ChartArea1";
            this.chartActiveUsers.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartActiveUsers.Legends.Add(legend3);
            this.chartActiveUsers.Location = new System.Drawing.Point(14, 681);
            this.chartActiveUsers.Name = "chartActiveUsers";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartActiveUsers.Series.Add(series3);
            this.chartActiveUsers.Size = new System.Drawing.Size(429, 319);
            this.chartActiveUsers.TabIndex = 11;
            this.chartActiveUsers.Text = "chart3";
            // 
            // chartBookCondition
            // 
            chartArea4.Name = "ChartArea1";
            this.chartBookCondition.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartBookCondition.Legends.Add(legend4);
            this.chartBookCondition.Location = new System.Drawing.Point(515, 681);
            this.chartBookCondition.Name = "chartBookCondition";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartBookCondition.Series.Add(series4);
            this.chartBookCondition.Size = new System.Drawing.Size(429, 319);
            this.chartBookCondition.TabIndex = 12;
            this.chartBookCondition.Text = "chart4";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(630, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 37);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export File";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 1046);
            this.Controls.Add(this.chartBookCondition);
            this.Controls.Add(this.chartActiveUsers);
            this.Controls.Add(this.chartBorrowingFrequency);
            this.Controls.Add(this.chartBookQuantity);
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
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrowingFrequency)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookQuantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBorrowingFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActiveUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookCondition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
    }
}