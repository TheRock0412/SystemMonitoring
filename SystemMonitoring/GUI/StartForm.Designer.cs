namespace SystemMonitoring.GUI
{
    partial class StartForm
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
            this.mlComputerName_Value = new MetroFramework.Controls.MetroLabel();
            this.mlComputerName = new MetroFramework.Controls.MetroLabel();
            this.mlMemory = new MetroFramework.Controls.MetroLabel();
            this.mlMemory_Value = new MetroFramework.Controls.MetroLabel();
            this.mlCPU = new MetroFramework.Controls.MetroLabel();
            this.mlCPU_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMonitor = new MetroFramework.Controls.MetroLabel();
            this.mlMonitor_Value = new MetroFramework.Controls.MetroLabel();
            this.mlGraphics = new MetroFramework.Controls.MetroLabel();
            this.mlGraphics_Value = new MetroFramework.Controls.MetroLabel();
            this.mlInternet = new MetroFramework.Controls.MetroLabel();
            this.mlInternet_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMainboard = new MetroFramework.Controls.MetroLabel();
            this.mlMainboard_Value = new MetroFramework.Controls.MetroLabel();
            this.mlDataMedium = new MetroFramework.Controls.MetroLabel();
            this.mlDataMedium_Value = new MetroFramework.Controls.MetroLabel();
            this.mlUserName = new MetroFramework.Controls.MetroLabel();
            this.mlUserName_Value = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlComputerName_Value
            // 
            this.mlComputerName_Value.AutoSize = true;
            this.mlComputerName_Value.ForeColor = System.Drawing.Color.SteelBlue;
            this.mlComputerName_Value.Location = new System.Drawing.Point(270, 25);
            this.mlComputerName_Value.Name = "mlComputerName_Value";
            this.mlComputerName_Value.Size = new System.Drawing.Size(83, 19);
            this.mlComputerName_Value.TabIndex = 7;
            this.mlComputerName_Value.Text = "metroLabel2";
            this.mlComputerName_Value.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mlComputerName
            // 
            this.mlComputerName.AutoSize = true;
            this.mlComputerName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlComputerName.ForeColor = System.Drawing.Color.SteelBlue;
            this.mlComputerName.Location = new System.Drawing.Point(12, 19);
            this.mlComputerName.Name = "mlComputerName";
            this.mlComputerName.Size = new System.Drawing.Size(131, 25);
            this.mlComputerName.TabIndex = 6;
            this.mlComputerName.Text = "Computername";
            // 
            // mlMemory
            // 
            this.mlMemory.AutoSize = true;
            this.mlMemory.Location = new System.Drawing.Point(12, 85);
            this.mlMemory.Name = "mlMemory";
            this.mlMemory.Size = new System.Drawing.Size(102, 19);
            this.mlMemory.TabIndex = 8;
            this.mlMemory.Text = "Arbeitsspeicher:";
            // 
            // mlMemory_Value
            // 
            this.mlMemory_Value.AutoSize = true;
            this.mlMemory_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMemory_Value.Location = new System.Drawing.Point(150, 87);
            this.mlMemory_Value.Name = "mlMemory_Value";
            this.mlMemory_Value.Size = new System.Drawing.Size(70, 15);
            this.mlMemory_Value.TabIndex = 9;
            this.mlMemory_Value.Text = "metroLabel4";
            // 
            // mlCPU
            // 
            this.mlCPU.AutoSize = true;
            this.mlCPU.Location = new System.Drawing.Point(12, 115);
            this.mlCPU.Name = "mlCPU";
            this.mlCPU.Size = new System.Drawing.Size(38, 19);
            this.mlCPU.TabIndex = 10;
            this.mlCPU.Text = "CPU:";
            // 
            // mlCPU_Value
            // 
            this.mlCPU_Value.AutoSize = true;
            this.mlCPU_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCPU_Value.Location = new System.Drawing.Point(150, 117);
            this.mlCPU_Value.Name = "mlCPU_Value";
            this.mlCPU_Value.Size = new System.Drawing.Size(70, 15);
            this.mlCPU_Value.TabIndex = 11;
            this.mlCPU_Value.Text = "metroLabel6";
            // 
            // mlMonitor
            // 
            this.mlMonitor.AutoSize = true;
            this.mlMonitor.Location = new System.Drawing.Point(12, 145);
            this.mlMonitor.Name = "mlMonitor";
            this.mlMonitor.Size = new System.Drawing.Size(60, 19);
            this.mlMonitor.TabIndex = 12;
            this.mlMonitor.Text = "Monitor:";
            // 
            // mlMonitor_Value
            // 
            this.mlMonitor_Value.AutoSize = true;
            this.mlMonitor_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMonitor_Value.Location = new System.Drawing.Point(150, 147);
            this.mlMonitor_Value.Name = "mlMonitor_Value";
            this.mlMonitor_Value.Size = new System.Drawing.Size(70, 15);
            this.mlMonitor_Value.TabIndex = 13;
            this.mlMonitor_Value.Text = "metroLabel8";
            // 
            // mlGraphics
            // 
            this.mlGraphics.AutoSize = true;
            this.mlGraphics.Location = new System.Drawing.Point(12, 175);
            this.mlGraphics.Name = "mlGraphics";
            this.mlGraphics.Size = new System.Drawing.Size(76, 19);
            this.mlGraphics.TabIndex = 14;
            this.mlGraphics.Text = "Grafikkarte:";
            // 
            // mlGraphics_Value
            // 
            this.mlGraphics_Value.AutoSize = true;
            this.mlGraphics_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlGraphics_Value.Location = new System.Drawing.Point(150, 177);
            this.mlGraphics_Value.Name = "mlGraphics_Value";
            this.mlGraphics_Value.Size = new System.Drawing.Size(74, 15);
            this.mlGraphics_Value.TabIndex = 15;
            this.mlGraphics_Value.Text = "metroLabel10";
            // 
            // mlInternet
            // 
            this.mlInternet.AutoSize = true;
            this.mlInternet.Location = new System.Drawing.Point(12, 205);
            this.mlInternet.Name = "mlInternet";
            this.mlInternet.Size = new System.Drawing.Size(120, 19);
            this.mlInternet.TabIndex = 16;
            this.mlInternet.Text = "Netzwerk-Adapter:";
            // 
            // mlInternet_Value
            // 
            this.mlInternet_Value.AutoSize = true;
            this.mlInternet_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlInternet_Value.Location = new System.Drawing.Point(150, 207);
            this.mlInternet_Value.Name = "mlInternet_Value";
            this.mlInternet_Value.Size = new System.Drawing.Size(74, 15);
            this.mlInternet_Value.TabIndex = 17;
            this.mlInternet_Value.Text = "metroLabel12";
            // 
            // mlMainboard
            // 
            this.mlMainboard.AutoSize = true;
            this.mlMainboard.Location = new System.Drawing.Point(12, 235);
            this.mlMainboard.Name = "mlMainboard";
            this.mlMainboard.Size = new System.Drawing.Size(77, 19);
            this.mlMainboard.TabIndex = 18;
            this.mlMainboard.Text = "Mainboard:";
            // 
            // mlMainboard_Value
            // 
            this.mlMainboard_Value.AutoSize = true;
            this.mlMainboard_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMainboard_Value.Location = new System.Drawing.Point(150, 237);
            this.mlMainboard_Value.Name = "mlMainboard_Value";
            this.mlMainboard_Value.Size = new System.Drawing.Size(74, 15);
            this.mlMainboard_Value.TabIndex = 19;
            this.mlMainboard_Value.Text = "metroLabel14";
            // 
            // mlDataMedium
            // 
            this.mlDataMedium.AutoSize = true;
            this.mlDataMedium.Location = new System.Drawing.Point(12, 265);
            this.mlDataMedium.Name = "mlDataMedium";
            this.mlDataMedium.Size = new System.Drawing.Size(83, 19);
            this.mlDataMedium.TabIndex = 20;
            this.mlDataMedium.Text = "Datenträger:";
            // 
            // mlDataMedium_Value
            // 
            this.mlDataMedium_Value.AutoSize = true;
            this.mlDataMedium_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlDataMedium_Value.Location = new System.Drawing.Point(150, 267);
            this.mlDataMedium_Value.Name = "mlDataMedium_Value";
            this.mlDataMedium_Value.Size = new System.Drawing.Size(74, 15);
            this.mlDataMedium_Value.TabIndex = 21;
            this.mlDataMedium_Value.Text = "metroLabel16";
            // 
            // mlUserName
            // 
            this.mlUserName.AutoSize = true;
            this.mlUserName.Location = new System.Drawing.Point(12, 44);
            this.mlUserName.Name = "mlUserName";
            this.mlUserName.Size = new System.Drawing.Size(127, 19);
            this.mlUserName.TabIndex = 30;
            this.mlUserName.Text = "Angemeldeter User:";
            // 
            // mlUserName_Value
            // 
            this.mlUserName_Value.AutoSize = true;
            this.mlUserName_Value.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlUserName_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlUserName_Value.Location = new System.Drawing.Point(270, 44);
            this.mlUserName_Value.Name = "mlUserName_Value";
            this.mlUserName_Value.Size = new System.Drawing.Size(76, 15);
            this.mlUserName_Value.TabIndex = 31;
            this.mlUserName_Value.Text = "metroLabel26";
            this.mlUserName_Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.mlUserName_Value);
            this.Controls.Add(this.mlUserName);
            this.Controls.Add(this.mlDataMedium_Value);
            this.Controls.Add(this.mlDataMedium);
            this.Controls.Add(this.mlMainboard_Value);
            this.Controls.Add(this.mlMainboard);
            this.Controls.Add(this.mlInternet_Value);
            this.Controls.Add(this.mlInternet);
            this.Controls.Add(this.mlGraphics_Value);
            this.Controls.Add(this.mlGraphics);
            this.Controls.Add(this.mlMonitor_Value);
            this.Controls.Add(this.mlMonitor);
            this.Controls.Add(this.mlCPU_Value);
            this.Controls.Add(this.mlCPU);
            this.Controls.Add(this.mlMemory_Value);
            this.Controls.Add(this.mlMemory);
            this.Controls.Add(this.mlComputerName_Value);
            this.Controls.Add(this.mlComputerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlComputerName_Value;
        private MetroFramework.Controls.MetroLabel mlComputerName;
        private MetroFramework.Controls.MetroLabel mlMemory;
        private MetroFramework.Controls.MetroLabel mlMemory_Value;
        private MetroFramework.Controls.MetroLabel mlCPU;
        private MetroFramework.Controls.MetroLabel mlCPU_Value;
        private MetroFramework.Controls.MetroLabel mlMonitor;
        private MetroFramework.Controls.MetroLabel mlMonitor_Value;
        private MetroFramework.Controls.MetroLabel mlGraphics;
        private MetroFramework.Controls.MetroLabel mlGraphics_Value;
        private MetroFramework.Controls.MetroLabel mlInternet;
        private MetroFramework.Controls.MetroLabel mlInternet_Value;
        private MetroFramework.Controls.MetroLabel mlMainboard;
        private MetroFramework.Controls.MetroLabel mlMainboard_Value;
        private MetroFramework.Controls.MetroLabel mlDataMedium;
        private MetroFramework.Controls.MetroLabel mlDataMedium_Value;
        private MetroFramework.Controls.MetroLabel mlUserName;
        private MetroFramework.Controls.MetroLabel mlUserName_Value;
    }
}