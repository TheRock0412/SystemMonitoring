﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormGrafikkarte : Form
    {
        public FormGrafikkarte()
        {
            InitializeComponent();

            metroLabel2.Text = Hardware.Grafikkarte.GPUName("Win32_VideoController", "Name");
        }
    }
}
