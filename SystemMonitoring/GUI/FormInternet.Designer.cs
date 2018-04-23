namespace SystemMonitoring.GUI
{
    partial class FormInternet
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mlInternet = new MetroFramework.Controls.MetroLabel();
            this.mlInternetAdapter_Value = new MetroFramework.Controls.MetroLabel();
            this.InternetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mlConnectionType = new MetroFramework.Controls.MetroLabel();
            this.mlConnectionType_Value = new MetroFramework.Controls.MetroLabel();
            this.mlDNS = new MetroFramework.Controls.MetroLabel();
            this.mlDNS_Value = new MetroFramework.Controls.MetroLabel();
            this.mlIP4 = new MetroFramework.Controls.MetroLabel();
            this.mlIP4_Value = new MetroFramework.Controls.MetroLabel();
            this.mlIP6 = new MetroFramework.Controls.MetroLabel();
            this.mlIP6_Value = new MetroFramework.Controls.MetroLabel();
            this.mlPhysicalAdress = new MetroFramework.Controls.MetroLabel();
            this.mlPhyiscalAdress_Value = new MetroFramework.Controls.MetroLabel();
            this.mlSend = new MetroFramework.Controls.MetroLabel();
            this.mlSend_Value = new MetroFramework.Controls.MetroLabel();
            this.mlReceive = new MetroFramework.Controls.MetroLabel();
            this.mlReceive_Value = new MetroFramework.Controls.MetroLabel();
            this.mlGateway = new MetroFramework.Controls.MetroLabel();
            this.mlGateway_Value = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.InternetChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mlInternet
            // 
            this.mlInternet.AutoSize = true;
            this.mlInternet.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlInternet.Location = new System.Drawing.Point(12, 19);
            this.mlInternet.Name = "mlInternet";
            this.mlInternet.Size = new System.Drawing.Size(70, 25);
            this.mlInternet.TabIndex = 0;
            this.mlInternet.Text = "Internet";
            // 
            // mlInternetAdapter_Value
            // 
            this.mlInternetAdapter_Value.AutoSize = true;
            this.mlInternetAdapter_Value.Location = new System.Drawing.Point(270, 25);
            this.mlInternetAdapter_Value.Name = "mlInternetAdapter_Value";
            this.mlInternetAdapter_Value.Size = new System.Drawing.Size(0, 0);
            this.mlInternetAdapter_Value.TabIndex = 1;
            // 
            // InternetChart
            // 
            this.InternetChart.BorderlineColor = System.Drawing.Color.SteelBlue;
            chartArea1.Name = "ChartArea1";
            this.InternetChart.ChartAreas.Add(chartArea1);
            this.InternetChart.Location = new System.Drawing.Point(6, 46);
            this.InternetChart.Name = "InternetChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Senden_Usage";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Empfangen_Usage";
            this.InternetChart.Series.Add(series1);
            this.InternetChart.Series.Add(series2);
            this.InternetChart.Size = new System.Drawing.Size(570, 200);
            this.InternetChart.TabIndex = 25;
            this.InternetChart.Text = "chart1";
            // 
            // mlConnectionType
            // 
            this.mlConnectionType.AutoSize = true;
            this.mlConnectionType.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlConnectionType.Location = new System.Drawing.Point(230, 260);
            this.mlConnectionType.Name = "mlConnectionType";
            this.mlConnectionType.Size = new System.Drawing.Size(88, 15);
            this.mlConnectionType.TabIndex = 26;
            this.mlConnectionType.Text = "Verbindungstyp:";
            // 
            // mlConnectionType_Value
            // 
            this.mlConnectionType_Value.AutoSize = true;
            this.mlConnectionType_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlConnectionType_Value.Location = new System.Drawing.Point(359, 260);
            this.mlConnectionType_Value.Name = "mlConnectionType_Value";
            this.mlConnectionType_Value.Size = new System.Drawing.Size(70, 15);
            this.mlConnectionType_Value.TabIndex = 27;
            this.mlConnectionType_Value.Text = "metroLabel4";
            // 
            // mlDNS
            // 
            this.mlDNS.AutoSize = true;
            this.mlDNS.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlDNS.Location = new System.Drawing.Point(230, 280);
            this.mlDNS.Name = "mlDNS";
            this.mlDNS.Size = new System.Drawing.Size(67, 15);
            this.mlDNS.TabIndex = 28;
            this.mlDNS.Text = "DNS-Surffix:";
            // 
            // mlDNS_Value
            // 
            this.mlDNS_Value.AutoSize = true;
            this.mlDNS_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlDNS_Value.Location = new System.Drawing.Point(359, 280);
            this.mlDNS_Value.Name = "mlDNS_Value";
            this.mlDNS_Value.Size = new System.Drawing.Size(70, 15);
            this.mlDNS_Value.TabIndex = 29;
            this.mlDNS_Value.Text = "metroLabel6";
            // 
            // mlIP4
            // 
            this.mlIP4.AutoSize = true;
            this.mlIP4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlIP4.Location = new System.Drawing.Point(230, 300);
            this.mlIP4.Name = "mlIP4";
            this.mlIP4.Size = new System.Drawing.Size(77, 15);
            this.mlIP4.TabIndex = 30;
            this.mlIP4.Text = "IPv4-Adresse:";
            // 
            // mlIP4_Value
            // 
            this.mlIP4_Value.AutoSize = true;
            this.mlIP4_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlIP4_Value.Location = new System.Drawing.Point(359, 300);
            this.mlIP4_Value.Name = "mlIP4_Value";
            this.mlIP4_Value.Size = new System.Drawing.Size(70, 15);
            this.mlIP4_Value.TabIndex = 31;
            this.mlIP4_Value.Text = "metroLabel8";
            // 
            // mlIP6
            // 
            this.mlIP6.AutoSize = true;
            this.mlIP6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlIP6.Location = new System.Drawing.Point(230, 320);
            this.mlIP6.Name = "mlIP6";
            this.mlIP6.Size = new System.Drawing.Size(77, 15);
            this.mlIP6.TabIndex = 32;
            this.mlIP6.Text = "IPv6-Adresse:";
            // 
            // mlIP6_Value
            // 
            this.mlIP6_Value.AutoSize = true;
            this.mlIP6_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlIP6_Value.Location = new System.Drawing.Point(359, 320);
            this.mlIP6_Value.Name = "mlIP6_Value";
            this.mlIP6_Value.Size = new System.Drawing.Size(74, 15);
            this.mlIP6_Value.TabIndex = 33;
            this.mlIP6_Value.Text = "metroLabel10";
            // 
            // mlPhysicalAdress
            // 
            this.mlPhysicalAdress.AutoSize = true;
            this.mlPhysicalAdress.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPhysicalAdress.Location = new System.Drawing.Point(230, 340);
            this.mlPhysicalAdress.Name = "mlPhysicalAdress";
            this.mlPhysicalAdress.Size = new System.Drawing.Size(101, 15);
            this.mlPhysicalAdress.TabIndex = 34;
            this.mlPhysicalAdress.Text = "Physische Adresse:";
            // 
            // mlPhyiscalAdress_Value
            // 
            this.mlPhyiscalAdress_Value.AutoSize = true;
            this.mlPhyiscalAdress_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPhyiscalAdress_Value.Location = new System.Drawing.Point(359, 340);
            this.mlPhyiscalAdress_Value.Name = "mlPhyiscalAdress_Value";
            this.mlPhyiscalAdress_Value.Size = new System.Drawing.Size(74, 15);
            this.mlPhyiscalAdress_Value.TabIndex = 35;
            this.mlPhyiscalAdress_Value.Text = "metroLabel12";
            // 
            // mlSend
            // 
            this.mlSend.AutoSize = true;
            this.mlSend.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSend.Location = new System.Drawing.Point(77, 260);
            this.mlSend.Name = "mlSend";
            this.mlSend.Size = new System.Drawing.Size(44, 15);
            this.mlSend.TabIndex = 36;
            this.mlSend.Text = "Senden";
            // 
            // mlSend_Value
            // 
            this.mlSend_Value.AutoSize = true;
            this.mlSend_Value.Location = new System.Drawing.Point(77, 280);
            this.mlSend_Value.Name = "mlSend_Value";
            this.mlSend_Value.Size = new System.Drawing.Size(52, 19);
            this.mlSend_Value.TabIndex = 37;
            this.mlSend_Value.Text = "0 KBit/s";
            // 
            // mlReceive
            // 
            this.mlReceive.AutoSize = true;
            this.mlReceive.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlReceive.Location = new System.Drawing.Point(77, 316);
            this.mlReceive.Name = "mlReceive";
            this.mlReceive.Size = new System.Drawing.Size(64, 15);
            this.mlReceive.TabIndex = 38;
            this.mlReceive.Text = "Empfangen";
            // 
            // mlReceive_Value
            // 
            this.mlReceive_Value.AutoSize = true;
            this.mlReceive_Value.Location = new System.Drawing.Point(77, 336);
            this.mlReceive_Value.Name = "mlReceive_Value";
            this.mlReceive_Value.Size = new System.Drawing.Size(52, 19);
            this.mlReceive_Value.TabIndex = 39;
            this.mlReceive_Value.Text = "0 KBit/s";
            // 
            // mlGateway
            // 
            this.mlGateway.AutoSize = true;
            this.mlGateway.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlGateway.Location = new System.Drawing.Point(230, 362);
            this.mlGateway.Name = "mlGateway";
            this.mlGateway.Size = new System.Drawing.Size(53, 15);
            this.mlGateway.TabIndex = 40;
            this.mlGateway.Text = "Gateway:";
            // 
            // mlGateway_Value
            // 
            this.mlGateway_Value.AutoSize = true;
            this.mlGateway_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlGateway_Value.Location = new System.Drawing.Point(359, 362);
            this.mlGateway_Value.Name = "mlGateway_Value";
            this.mlGateway_Value.Size = new System.Drawing.Size(74, 15);
            this.mlGateway_Value.TabIndex = 41;
            this.mlGateway_Value.Text = "metroLabel18";
            // 
            // FormInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.mlGateway_Value);
            this.Controls.Add(this.mlGateway);
            this.Controls.Add(this.mlReceive_Value);
            this.Controls.Add(this.mlReceive);
            this.Controls.Add(this.mlSend_Value);
            this.Controls.Add(this.mlSend);
            this.Controls.Add(this.mlPhyiscalAdress_Value);
            this.Controls.Add(this.mlPhysicalAdress);
            this.Controls.Add(this.mlIP6_Value);
            this.Controls.Add(this.mlIP6);
            this.Controls.Add(this.mlIP4_Value);
            this.Controls.Add(this.mlIP4);
            this.Controls.Add(this.mlDNS_Value);
            this.Controls.Add(this.mlDNS);
            this.Controls.Add(this.mlConnectionType_Value);
            this.Controls.Add(this.mlConnectionType);
            this.Controls.Add(this.InternetChart);
            this.Controls.Add(this.mlInternetAdapter_Value);
            this.Controls.Add(this.mlInternet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInternet";
            this.Text = "FormEthernet";
            this.Load += new System.EventHandler(this.FormInternet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternetChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlInternet;
        private MetroFramework.Controls.MetroLabel mlInternetAdapter_Value;
        private System.Windows.Forms.DataVisualization.Charting.Chart InternetChart;
        private MetroFramework.Controls.MetroLabel mlConnectionType;
        private MetroFramework.Controls.MetroLabel mlConnectionType_Value;
        private MetroFramework.Controls.MetroLabel mlDNS;
        private MetroFramework.Controls.MetroLabel mlDNS_Value;
        private MetroFramework.Controls.MetroLabel mlIP4;
        private MetroFramework.Controls.MetroLabel mlIP4_Value;
        private MetroFramework.Controls.MetroLabel mlIP6;
        private MetroFramework.Controls.MetroLabel mlIP6_Value;
        private MetroFramework.Controls.MetroLabel mlPhysicalAdress;
        private MetroFramework.Controls.MetroLabel mlPhyiscalAdress_Value;
        private MetroFramework.Controls.MetroLabel mlSend;
        private MetroFramework.Controls.MetroLabel mlSend_Value;
        private MetroFramework.Controls.MetroLabel mlReceive;
        private MetroFramework.Controls.MetroLabel mlReceive_Value;
        private MetroFramework.Controls.MetroLabel mlGateway;
        private MetroFramework.Controls.MetroLabel mlGateway_Value;
    }
}