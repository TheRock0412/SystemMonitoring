namespace SystemMonitoring.GUI
{
    partial class FormCPU
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
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mlCPUName = new MetroFramework.Controls.MetroLabel();
            this.mlCPUName_Value = new MetroFramework.Controls.MetroLabel();
            this.mlCPUSpeed = new MetroFramework.Controls.MetroLabel();
            this.mlCPUSpeed_Value = new MetroFramework.Controls.MetroLabel();
            this.mlCPUTemp = new MetroFramework.Controls.MetroLabel();
            this.mlCPUTemp_Value = new MetroFramework.Controls.MetroLabel();
            this.mlCPUInVerwendung = new MetroFramework.Controls.MetroLabel();
            this.mlCPUInVerwendung_Value = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuChart
            // 
            this.cpuChart.BorderlineColor = System.Drawing.Color.SteelBlue;
            chartArea1.BorderColor = System.Drawing.Color.SteelBlue;
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            this.cpuChart.Location = new System.Drawing.Point(6, 46);
            this.cpuChart.Name = "cpuChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "CPU_Usage";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(570, 200);
            this.cpuChart.TabIndex = 25;
            this.cpuChart.Text = "chart1";
            // 
            // mlCPUName
            // 
            this.mlCPUName.AutoSize = true;
            this.mlCPUName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlCPUName.Location = new System.Drawing.Point(12, 19);
            this.mlCPUName.Name = "mlCPUName";
            this.mlCPUName.Size = new System.Drawing.Size(45, 25);
            this.mlCPUName.TabIndex = 5;
            this.mlCPUName.Text = "CPU";
            // 
            // mlCPUName_Value
            // 
            this.mlCPUName_Value.AutoSize = true;
            this.mlCPUName_Value.Location = new System.Drawing.Point(270, 25);
            this.mlCPUName_Value.Name = "mlCPUName_Value";
            this.mlCPUName_Value.Size = new System.Drawing.Size(83, 19);
            this.mlCPUName_Value.TabIndex = 6;
            this.mlCPUName_Value.Text = "metroLabel2";
            // 
            // mlCPUSpeed
            // 
            this.mlCPUSpeed.AutoSize = true;
            this.mlCPUSpeed.Location = new System.Drawing.Point(12, 256);
            this.mlCPUSpeed.Name = "mlCPUSpeed";
            this.mlCPUSpeed.Size = new System.Drawing.Size(79, 19);
            this.mlCPUSpeed.TabIndex = 7;
            this.mlCPUSpeed.Text = "CPU Speed:";
            // 
            // mlCPUSpeed_Value
            // 
            this.mlCPUSpeed_Value.AutoSize = true;
            this.mlCPUSpeed_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCPUSpeed_Value.Location = new System.Drawing.Point(63, 278);
            this.mlCPUSpeed_Value.Name = "mlCPUSpeed_Value";
            this.mlCPUSpeed_Value.Size = new System.Drawing.Size(38, 15);
            this.mlCPUSpeed_Value.TabIndex = 8;
            this.mlCPUSpeed_Value.Text = "0 GHz";
            // 
            // mlCPUTemp
            // 
            this.mlCPUTemp.AutoSize = true;
            this.mlCPUTemp.Location = new System.Drawing.Point(130, 256);
            this.mlCPUTemp.Name = "mlCPUTemp";
            this.mlCPUTemp.Size = new System.Drawing.Size(74, 19);
            this.mlCPUTemp.TabIndex = 26;
            this.mlCPUTemp.Text = "CPU Temp:";
            // 
            // mlCPUTemp_Value
            // 
            this.mlCPUTemp_Value.AutoSize = true;
            this.mlCPUTemp_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCPUTemp_Value.Location = new System.Drawing.Point(179, 278);
            this.mlCPUTemp_Value.Name = "mlCPUTemp_Value";
            this.mlCPUTemp_Value.Size = new System.Drawing.Size(28, 15);
            this.mlCPUTemp_Value.TabIndex = 27;
            this.mlCPUTemp_Value.Text = "0 °C";
            // 
            // mlCPUInVerwendung
            // 
            this.mlCPUInVerwendung.AutoSize = true;
            this.mlCPUInVerwendung.Location = new System.Drawing.Point(12, 319);
            this.mlCPUInVerwendung.Name = "mlCPUInVerwendung";
            this.mlCPUInVerwendung.Size = new System.Drawing.Size(99, 19);
            this.mlCPUInVerwendung.TabIndex = 28;
            this.mlCPUInVerwendung.Text = "In Verwendung:";
            // 
            // mlCPUInVerwendung_Value
            // 
            this.mlCPUInVerwendung_Value.AutoSize = true;
            this.mlCPUInVerwendung_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCPUInVerwendung_Value.Location = new System.Drawing.Point(63, 341);
            this.mlCPUInVerwendung_Value.Name = "mlCPUInVerwendung_Value";
            this.mlCPUInVerwendung_Value.Size = new System.Drawing.Size(25, 15);
            this.mlCPUInVerwendung_Value.TabIndex = 29;
            this.mlCPUInVerwendung_Value.Text = "0 %";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(130, 319);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "metroLabel9";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(181, 341);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "metroLabel10";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(270, 258);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 15);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "metroLabel11";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.Location = new System.Drawing.Point(270, 278);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(88, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "metroLabel12";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.Location = new System.Drawing.Point(275, 319);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(74, 15);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "metroLabel13";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.Location = new System.Drawing.Point(275, 341);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(74, 15);
            this.metroLabel14.TabIndex = 35;
            this.metroLabel14.Text = "metroLabel14";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.Location = new System.Drawing.Point(399, 258);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(88, 19);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "metroLabel15";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel16.Location = new System.Drawing.Point(399, 278);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(74, 15);
            this.metroLabel16.TabIndex = 37;
            this.metroLabel16.Text = "metroLabel16";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.Location = new System.Drawing.Point(387, 318);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(74, 15);
            this.metroLabel17.TabIndex = 38;
            this.metroLabel17.Text = "metroLabel17";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.Location = new System.Drawing.Point(387, 341);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(74, 15);
            this.metroLabel18.TabIndex = 39;
            this.metroLabel18.Text = "metroLabel18";
            // 
            // FormCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mlCPUInVerwendung_Value);
            this.Controls.Add(this.mlCPUInVerwendung);
            this.Controls.Add(this.mlCPUTemp_Value);
            this.Controls.Add(this.mlCPUTemp);
            this.Controls.Add(this.mlCPUSpeed_Value);
            this.Controls.Add(this.mlCPUSpeed);
            this.Controls.Add(this.mlCPUName_Value);
            this.Controls.Add(this.mlCPUName);
            this.Controls.Add(this.cpuChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCPU";
            this.Text = "FormCPU";
            this.Load += new System.EventHandler(this.FormCPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private MetroFramework.Controls.MetroLabel mlCPUName;
        private MetroFramework.Controls.MetroLabel mlCPUName_Value;
        private MetroFramework.Controls.MetroLabel mlCPUSpeed;
        private MetroFramework.Controls.MetroLabel mlCPUSpeed_Value;
        private MetroFramework.Controls.MetroLabel mlCPUTemp;
        private MetroFramework.Controls.MetroLabel mlCPUTemp_Value;
        private MetroFramework.Controls.MetroLabel mlCPUInVerwendung;
        private MetroFramework.Controls.MetroLabel mlCPUInVerwendung_Value;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
    }
}