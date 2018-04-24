namespace SystemMonitoring.GUI
{
    partial class FormMemory
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MemoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mlFreeMemory = new MetroFramework.Controls.MetroLabel();
            this.mlFreeMemory_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMemorySize = new MetroFramework.Controls.MetroLabel();
            this.mlMemorySize_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMemoryCommitted = new MetroFramework.Controls.MetroLabel();
            this.mlMemoryCommitted_Value = new MetroFramework.Controls.MetroLabel();
            this.mlPartNumber = new MetroFramework.Controls.MetroLabel();
            this.mlPartNumber_Value = new MetroFramework.Controls.MetroLabel();
            this.mlManufacturer = new MetroFramework.Controls.MetroLabel();
            this.mlManufacturer_Value = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MemoryChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MemoryChart.ChartAreas.Add(chartArea1);
            this.MemoryChart.Location = new System.Drawing.Point(6, 46);
            this.MemoryChart.Name = "MemoryChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "RAM_Usage";
            this.MemoryChart.Series.Add(series1);
            this.MemoryChart.Size = new System.Drawing.Size(570, 200);
            this.MemoryChart.TabIndex = 25;
            this.MemoryChart.Text = "chart1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Arbeitsspeicher";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(270, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // mlFreeMemory
            // 
            this.mlFreeMemory.AutoSize = true;
            this.mlFreeMemory.Location = new System.Drawing.Point(12, 256);
            this.mlFreeMemory.Name = "mlFreeMemory";
            this.mlFreeMemory.Size = new System.Drawing.Size(101, 19);
            this.mlFreeMemory.TabIndex = 28;
            this.mlFreeMemory.Text = "Freier Speicher:";
            // 
            // mlFreeMemory_Value
            // 
            this.mlFreeMemory_Value.AutoSize = true;
            this.mlFreeMemory_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlFreeMemory_Value.Location = new System.Drawing.Point(78, 279);
            this.mlFreeMemory_Value.Name = "mlFreeMemory_Value";
            this.mlFreeMemory_Value.Size = new System.Drawing.Size(33, 15);
            this.mlFreeMemory_Value.TabIndex = 29;
            this.mlFreeMemory_Value.Text = "0 MB";
            // 
            // mlMemorySize
            // 
            this.mlMemorySize.AutoSize = true;
            this.mlMemorySize.Location = new System.Drawing.Point(130, 256);
            this.mlMemorySize.Name = "mlMemorySize";
            this.mlMemorySize.Size = new System.Drawing.Size(102, 19);
            this.mlMemorySize.TabIndex = 30;
            this.mlMemorySize.Text = "Speicher Größe:";
            // 
            // mlMemorySize_Value
            // 
            this.mlMemorySize_Value.AutoSize = true;
            this.mlMemorySize_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMemorySize_Value.Location = new System.Drawing.Point(192, 279);
            this.mlMemorySize_Value.Name = "mlMemorySize_Value";
            this.mlMemorySize_Value.Size = new System.Drawing.Size(40, 19);
            this.mlMemorySize_Value.TabIndex = 31;
            this.mlMemorySize_Value.Text = "0 MB";
            // 
            // mlMemoryCommitted
            // 
            this.mlMemoryCommitted.AutoSize = true;
            this.mlMemoryCommitted.Location = new System.Drawing.Point(12, 319);
            this.mlMemoryCommitted.Name = "mlMemoryCommitted";
            this.mlMemoryCommitted.Size = new System.Drawing.Size(99, 19);
            this.mlMemoryCommitted.TabIndex = 32;
            this.mlMemoryCommitted.Text = "In Verwendung:";
            // 
            // mlMemoryCommitted_Value
            // 
            this.mlMemoryCommitted_Value.AutoSize = true;
            this.mlMemoryCommitted_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMemoryCommitted_Value.Location = new System.Drawing.Point(78, 342);
            this.mlMemoryCommitted_Value.Name = "mlMemoryCommitted_Value";
            this.mlMemoryCommitted_Value.Size = new System.Drawing.Size(33, 15);
            this.mlMemoryCommitted_Value.TabIndex = 33;
            this.mlMemoryCommitted_Value.Text = "0 MB";
            // 
            // mlPartNumber
            // 
            this.mlPartNumber.AutoSize = true;
            this.mlPartNumber.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPartNumber.Location = new System.Drawing.Point(270, 258);
            this.mlPartNumber.Name = "mlPartNumber";
            this.mlPartNumber.Size = new System.Drawing.Size(77, 15);
            this.mlPartNumber.TabIndex = 34;
            this.mlPartNumber.Text = "Part Number:";
            // 
            // mlPartNumber_Value
            // 
            this.mlPartNumber_Value.AutoSize = true;
            this.mlPartNumber_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPartNumber_Value.Location = new System.Drawing.Point(399, 258);
            this.mlPartNumber_Value.Name = "mlPartNumber_Value";
            this.mlPartNumber_Value.Size = new System.Drawing.Size(70, 15);
            this.mlPartNumber_Value.TabIndex = 35;
            this.mlPartNumber_Value.Text = "metroLabel3";
            // 
            // mlManufacturer
            // 
            this.mlManufacturer.AutoSize = true;
            this.mlManufacturer.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlManufacturer.Location = new System.Drawing.Point(270, 278);
            this.mlManufacturer.Name = "mlManufacturer";
            this.mlManufacturer.Size = new System.Drawing.Size(58, 15);
            this.mlManufacturer.TabIndex = 36;
            this.mlManufacturer.Text = "Hersteller:";
            // 
            // mlManufacturer_Value
            // 
            this.mlManufacturer_Value.AutoSize = true;
            this.mlManufacturer_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlManufacturer_Value.Location = new System.Drawing.Point(399, 278);
            this.mlManufacturer_Value.Name = "mlManufacturer_Value";
            this.mlManufacturer_Value.Size = new System.Drawing.Size(83, 19);
            this.mlManufacturer_Value.TabIndex = 37;
            this.mlManufacturer_Value.Text = "metroLabel3";
            // 
            // FormMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.mlManufacturer_Value);
            this.Controls.Add(this.mlManufacturer);
            this.Controls.Add(this.mlPartNumber_Value);
            this.Controls.Add(this.mlPartNumber);
            this.Controls.Add(this.mlMemoryCommitted_Value);
            this.Controls.Add(this.mlMemoryCommitted);
            this.Controls.Add(this.mlMemorySize_Value);
            this.Controls.Add(this.mlMemorySize);
            this.Controls.Add(this.mlFreeMemory_Value);
            this.Controls.Add(this.mlFreeMemory);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MemoryChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMemory";
            this.Text = "FormArbeitsspeicher";
            this.Load += new System.EventHandler(this.FormArbeitsspeicher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemoryChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MemoryChart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mlFreeMemory;
        private MetroFramework.Controls.MetroLabel mlFreeMemory_Value;
        private MetroFramework.Controls.MetroLabel mlMemorySize;
        private MetroFramework.Controls.MetroLabel mlMemorySize_Value;
        private MetroFramework.Controls.MetroLabel mlMemoryCommitted;
        private MetroFramework.Controls.MetroLabel mlMemoryCommitted_Value;
        private MetroFramework.Controls.MetroLabel mlPartNumber;
        private MetroFramework.Controls.MetroLabel mlPartNumber_Value;
        private MetroFramework.Controls.MetroLabel mlManufacturer;
        private MetroFramework.Controls.MetroLabel mlManufacturer_Value;
    }
}