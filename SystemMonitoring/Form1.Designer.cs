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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Arbeitsspeicher");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CPU");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Datenträger");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Grafikkarte");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mainboard");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Monitor");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hardware", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Software");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 64);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Arbeitsspeicher";
            treeNode1.Text = "Arbeitsspeicher";
            treeNode2.Name = "CPU";
            treeNode2.Text = "CPU";
            treeNode3.Name = "Datenträger";
            treeNode3.Text = "Datenträger";
            treeNode4.Name = "Grafikkarte";
            treeNode4.Text = "Grafikkarte";
            treeNode5.Name = "Internet";
            treeNode5.Text = "Internet";
            treeNode6.Name = "Mainboard";
            treeNode6.Text = "Mainboard";
            treeNode7.Name = "Monitor";
            treeNode7.Text = "Monitor";
            treeNode8.Name = "treeview1";
            treeNode8.Text = "Hardware";
            treeNode9.Name = "Software";
            treeNode9.Text = "Software";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
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

