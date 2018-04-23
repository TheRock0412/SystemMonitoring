namespace SystemMonitoring.GUI
{
    partial class FormMonitor
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
            this.mlMonitor = new MetroFramework.Controls.MetroLabel();
            this.mlManufacturer = new MetroFramework.Controls.MetroLabel();
            this.mlManufacturer_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMonitorType = new MetroFramework.Controls.MetroLabel();
            this.mlMonitorType_Value = new MetroFramework.Controls.MetroLabel();
            this.mlDisplayFormat = new MetroFramework.Controls.MetroLabel();
            this.mlDisplayFormat_Value = new MetroFramework.Controls.MetroLabel();
            this.mlStatus = new MetroFramework.Controls.MetroLabel();
            this.mlStatus_Value = new MetroFramework.Controls.MetroLabel();
            this.mlPNPDevice = new MetroFramework.Controls.MetroLabel();
            this.mlPNPDevice_Value = new MetroFramework.Controls.MetroLabel();
            this.Combox_Monitor = new MetroFramework.Controls.MetroComboBox();
            this.mlDeviceID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.mlDevice_Value = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlMonitor
            // 
            this.mlMonitor.AutoSize = true;
            this.mlMonitor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlMonitor.Location = new System.Drawing.Point(12, 19);
            this.mlMonitor.Name = "mlMonitor";
            this.mlMonitor.Size = new System.Drawing.Size(72, 25);
            this.mlMonitor.TabIndex = 0;
            this.mlMonitor.Text = "Monitor";
            // 
            // mlManufacturer
            // 
            this.mlManufacturer.AutoSize = true;
            this.mlManufacturer.Location = new System.Drawing.Point(12, 85);
            this.mlManufacturer.Name = "mlManufacturer";
            this.mlManufacturer.Size = new System.Drawing.Size(68, 19);
            this.mlManufacturer.TabIndex = 2;
            this.mlManufacturer.Text = "Hersteller:";
            // 
            // mlManufacturer_Value
            // 
            this.mlManufacturer_Value.AutoSize = true;
            this.mlManufacturer_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlManufacturer_Value.Location = new System.Drawing.Point(150, 87);
            this.mlManufacturer_Value.Name = "mlManufacturer_Value";
            this.mlManufacturer_Value.Size = new System.Drawing.Size(70, 15);
            this.mlManufacturer_Value.TabIndex = 3;
            this.mlManufacturer_Value.Text = "metroLabel4";
            // 
            // mlMonitorType
            // 
            this.mlMonitorType.AutoSize = true;
            this.mlMonitorType.Location = new System.Drawing.Point(12, 115);
            this.mlMonitorType.Name = "mlMonitorType";
            this.mlMonitorType.Size = new System.Drawing.Size(83, 19);
            this.mlMonitorType.TabIndex = 4;
            this.mlMonitorType.Text = "Monitor Typ:";
            // 
            // mlMonitorType_Value
            // 
            this.mlMonitorType_Value.AutoSize = true;
            this.mlMonitorType_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMonitorType_Value.Location = new System.Drawing.Point(150, 117);
            this.mlMonitorType_Value.Name = "mlMonitorType_Value";
            this.mlMonitorType_Value.Size = new System.Drawing.Size(70, 15);
            this.mlMonitorType_Value.TabIndex = 5;
            this.mlMonitorType_Value.Text = "metroLabel6";
            // 
            // mlDisplayFormat
            // 
            this.mlDisplayFormat.AutoSize = true;
            this.mlDisplayFormat.Location = new System.Drawing.Point(12, 145);
            this.mlDisplayFormat.Name = "mlDisplayFormat";
            this.mlDisplayFormat.Size = new System.Drawing.Size(70, 19);
            this.mlDisplayFormat.TabIndex = 6;
            this.mlDisplayFormat.Text = "Auflösung:";
            // 
            // mlDisplayFormat_Value
            // 
            this.mlDisplayFormat_Value.AutoSize = true;
            this.mlDisplayFormat_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlDisplayFormat_Value.Location = new System.Drawing.Point(150, 147);
            this.mlDisplayFormat_Value.Name = "mlDisplayFormat_Value";
            this.mlDisplayFormat_Value.Size = new System.Drawing.Size(70, 15);
            this.mlDisplayFormat_Value.TabIndex = 7;
            this.mlDisplayFormat_Value.Text = "metroLabel8";
            // 
            // mlStatus
            // 
            this.mlStatus.AutoSize = true;
            this.mlStatus.Location = new System.Drawing.Point(12, 175);
            this.mlStatus.Name = "mlStatus";
            this.mlStatus.Size = new System.Drawing.Size(46, 19);
            this.mlStatus.TabIndex = 8;
            this.mlStatus.Text = "Status:";
            // 
            // mlStatus_Value
            // 
            this.mlStatus_Value.AutoSize = true;
            this.mlStatus_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlStatus_Value.Location = new System.Drawing.Point(150, 177);
            this.mlStatus_Value.Name = "mlStatus_Value";
            this.mlStatus_Value.Size = new System.Drawing.Size(74, 15);
            this.mlStatus_Value.TabIndex = 9;
            this.mlStatus_Value.Text = "metroLabel10";
            // 
            // mlPNPDevice
            // 
            this.mlPNPDevice.AutoSize = true;
            this.mlPNPDevice.Location = new System.Drawing.Point(12, 205);
            this.mlPNPDevice.Name = "mlPNPDevice";
            this.mlPNPDevice.Size = new System.Drawing.Size(92, 19);
            this.mlPNPDevice.TabIndex = 10;
            this.mlPNPDevice.Text = "PNP DeviceID:";
            // 
            // mlPNPDevice_Value
            // 
            this.mlPNPDevice_Value.AutoSize = true;
            this.mlPNPDevice_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPNPDevice_Value.Location = new System.Drawing.Point(150, 207);
            this.mlPNPDevice_Value.Name = "mlPNPDevice_Value";
            this.mlPNPDevice_Value.Size = new System.Drawing.Size(74, 15);
            this.mlPNPDevice_Value.TabIndex = 11;
            this.mlPNPDevice_Value.Text = "metroLabel12";
            // 
            // Combox_Monitor
            // 
            this.Combox_Monitor.FormattingEnabled = true;
            this.Combox_Monitor.ItemHeight = 23;
            this.Combox_Monitor.Location = new System.Drawing.Point(270, 17);
            this.Combox_Monitor.Margin = new System.Windows.Forms.Padding(2);
            this.Combox_Monitor.Name = "Combox_Monitor";
            this.Combox_Monitor.Size = new System.Drawing.Size(249, 29);
            this.Combox_Monitor.TabIndex = 12;
            this.Combox_Monitor.UseSelectable = true;
            this.Combox_Monitor.SelectionChangeCommitted += new System.EventHandler(this.Combox_Monitor_SelectionChanged);
            // 
            // mlDeviceID
            // 
            this.mlDeviceID.AutoSize = true;
            this.mlDeviceID.Location = new System.Drawing.Point(12, 235);
            this.mlDeviceID.Name = "mlDeviceID";
            this.mlDeviceID.Size = new System.Drawing.Size(66, 19);
            this.mlDeviceID.TabIndex = 13;
            this.mlDeviceID.Text = "DeviceID: ";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(12, 265);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(88, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "metroLabel14";
            // 
            // mlDevice_Value
            // 
            this.mlDevice_Value.AutoSize = true;
            this.mlDevice_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlDevice_Value.Location = new System.Drawing.Point(150, 237);
            this.mlDevice_Value.Name = "mlDevice_Value";
            this.mlDevice_Value.Size = new System.Drawing.Size(68, 15);
            this.mlDevice_Value.TabIndex = 16;
            this.mlDevice_Value.Text = "metroLabel1";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.Location = new System.Drawing.Point(150, 267);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(74, 15);
            this.metroLabel15.TabIndex = 17;
            this.metroLabel15.Text = "metroLabel15";
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.mlDevice_Value);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.mlDeviceID);
            this.Controls.Add(this.Combox_Monitor);
            this.Controls.Add(this.mlPNPDevice_Value);
            this.Controls.Add(this.mlPNPDevice);
            this.Controls.Add(this.mlStatus_Value);
            this.Controls.Add(this.mlStatus);
            this.Controls.Add(this.mlDisplayFormat_Value);
            this.Controls.Add(this.mlDisplayFormat);
            this.Controls.Add(this.mlMonitorType_Value);
            this.Controls.Add(this.mlMonitorType);
            this.Controls.Add(this.mlManufacturer_Value);
            this.Controls.Add(this.mlManufacturer);
            this.Controls.Add(this.mlMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonitor";
            this.Text = "FormBildschirm";
            this.Load += new System.EventHandler(this.FormMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlMonitor;
        private MetroFramework.Controls.MetroLabel mlManufacturer;
        private MetroFramework.Controls.MetroLabel mlManufacturer_Value;
        private MetroFramework.Controls.MetroLabel mlMonitorType;
        private MetroFramework.Controls.MetroLabel mlMonitorType_Value;
        private MetroFramework.Controls.MetroLabel mlDisplayFormat;
        private MetroFramework.Controls.MetroLabel mlDisplayFormat_Value;
        private MetroFramework.Controls.MetroLabel mlStatus;
        private MetroFramework.Controls.MetroLabel mlStatus_Value;
        private MetroFramework.Controls.MetroLabel mlPNPDevice;
        private MetroFramework.Controls.MetroLabel mlPNPDevice_Value;
        private MetroFramework.Controls.MetroComboBox Combox_Monitor;
        private MetroFramework.Controls.MetroLabel mlDeviceID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel mlDevice_Value;
        private MetroFramework.Controls.MetroLabel metroLabel15;
    }
}