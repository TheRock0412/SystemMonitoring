namespace SystemMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Mainboard");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("CPU");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Arbeitsspeicher");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Grafikkarte");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Datenträger");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ethernet");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("MANU-GAMING_PC", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 64);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = "Mainboard";
            treeNode8.Text = "Mainboard";
            treeNode9.Name = "CPU";
            treeNode9.Text = "CPU";
            treeNode10.Name = "Arbeitsspeicher";
            treeNode10.Text = "Arbeitsspeicher";
            treeNode11.Name = "Grafikkarte";
            treeNode11.Text = "Grafikkarte";
            treeNode12.Name = "Datenträger";
            treeNode12.Text = "Datenträger";
            treeNode13.Name = "Ethernet";
            treeNode13.Text = "Ethernet";
            treeNode14.Name = "MANU-GAMING_PC";
            treeNode14.Text = "MANU-GAMING_PC";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(187, 389);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // MainPanel
            // 
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(220, 64);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(565, 389);
            this.MainPanel.TabIndex = 41;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 476);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "System Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroPanel MainPanel;
    }
}

