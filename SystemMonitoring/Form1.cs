using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using SystemMonitoring.Hardware;

namespace SystemMonitoring
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Form f;

        public Form1()
        {
            InitializeComponent();

            treeView1.ExpandAll();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            switch (node.Text)
            {
                case "Hardware":
                    f.Dispose();
                    f = new GUI.StartForm();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Mainboard":
                    f.Dispose();
                    f = new GUI.FormMainboard();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "CPU":
                    f.Dispose();
                    f = new GUI.FormCPU();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Arbeitsspeicher":
                    f.Dispose();
                    f = new GUI.FormArbeitsspeicher();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Grafikkarte":
                    f.Dispose();
                    f = new GUI.FormGrafikkarte();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Datenträger":
                    f.Dispose();
                    f = new GUI.FormDatenträger();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Internet":
                    f.Dispose();
                    f = new GUI.FormInternet();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Monitor":
                    f.Dispose();
                    f = new GUI.FormBildschirm();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "Software":
                    f.Dispose();
                    f = new GUI.FormSoftware();
                    f.TopLevel = false;

                    this.MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                default:
                    Console.WriteLine("Kann nicht gefunden werden!");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();

            f = new GUI.StartForm();
            f.TopLevel = false;

            this.MainPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}