namespace SystemMonitoring.GUI
{
    partial class FormDatenträger
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
            this.mlFormDatenträger = new MetroFramework.Controls.MetroLabel();
            this.combox_Datenträger = new MetroFramework.Controls.MetroComboBox();
            this.mlInterfaceType_Value = new MetroFramework.Controls.MetroLabel();
            this.mlModel = new MetroFramework.Controls.MetroLabel();
            this.mlModel_Value = new MetroFramework.Controls.MetroLabel();
            this.mlMediaType = new MetroFramework.Controls.MetroLabel();
            this.mlMediaType_Value = new MetroFramework.Controls.MetroLabel();
            this.mlSerialNumber = new MetroFramework.Controls.MetroLabel();
            this.mlSerialNumber_Value = new MetroFramework.Controls.MetroLabel();
            this.mlInterfaceType = new MetroFramework.Controls.MetroLabel();
            this.mlPartition = new MetroFramework.Controls.MetroLabel();
            this.mlSize = new MetroFramework.Controls.MetroLabel();
            this.mlSignature = new MetroFramework.Controls.MetroLabel();
            this.mlFirmwareRevision = new MetroFramework.Controls.MetroLabel();
            this.mlFirmware_Value = new MetroFramework.Controls.MetroLabel();
            this.mlSize_Value = new MetroFramework.Controls.MetroLabel();
            this.mlPartitions_Value = new MetroFramework.Controls.MetroLabel();
            this.mlSignature_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTotalCylinders = new MetroFramework.Controls.MetroLabel();
            this.mlCylinders_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTotalSectors = new MetroFramework.Controls.MetroLabel();
            this.mlSectors_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTotalHeads = new MetroFramework.Controls.MetroLabel();
            this.mlHeads_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTracks_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTotalTracks = new MetroFramework.Controls.MetroLabel();
            this.mlBytesPerSector = new MetroFramework.Controls.MetroLabel();
            this.mlBytesPerSector_Value = new MetroFramework.Controls.MetroLabel();
            this.mlSectorsPerTrack = new MetroFramework.Controls.MetroLabel();
            this.mlTracksPerCylinder = new MetroFramework.Controls.MetroLabel();
            this.mlSectorsPerTrack_Value = new MetroFramework.Controls.MetroLabel();
            this.mlTracksPerCylinder_Value = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlFormDatenträger
            // 
            this.mlFormDatenträger.AutoSize = true;
            this.mlFormDatenträger.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlFormDatenträger.Location = new System.Drawing.Point(12, 19);
            this.mlFormDatenträger.Name = "mlFormDatenträger";
            this.mlFormDatenträger.Size = new System.Drawing.Size(102, 25);
            this.mlFormDatenträger.TabIndex = 0;
            this.mlFormDatenträger.Text = "Datenträger";
            // 
            // combox_Datenträger
            // 
            this.combox_Datenträger.FormattingEnabled = true;
            this.combox_Datenträger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combox_Datenträger.ItemHeight = 23;
            this.combox_Datenträger.Location = new System.Drawing.Point(270, 17);
            this.combox_Datenträger.Name = "combox_Datenträger";
            this.combox_Datenträger.Size = new System.Drawing.Size(249, 29);
            this.combox_Datenträger.TabIndex = 2;
            this.combox_Datenträger.UseSelectable = true;
            this.combox_Datenträger.Click += new System.EventHandler(this.combox_Datenträger_SelectionChanged);
            // 
            // mlInterfaceType_Value
            // 
            this.mlInterfaceType_Value.AutoSize = true;
            this.mlInterfaceType_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlInterfaceType_Value.Location = new System.Drawing.Point(150, 177);
            this.mlInterfaceType_Value.Name = "mlInterfaceType_Value";
            this.mlInterfaceType_Value.Size = new System.Drawing.Size(70, 15);
            this.mlInterfaceType_Value.TabIndex = 3;
            this.mlInterfaceType_Value.Text = "metroLabel2";
            // 
            // mlModel
            // 
            this.mlModel.AutoSize = true;
            this.mlModel.Location = new System.Drawing.Point(12, 85);
            this.mlModel.Name = "mlModel";
            this.mlModel.Size = new System.Drawing.Size(50, 19);
            this.mlModel.TabIndex = 4;
            this.mlModel.Text = "Model:";
            // 
            // mlModel_Value
            // 
            this.mlModel_Value.AutoSize = true;
            this.mlModel_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlModel_Value.Location = new System.Drawing.Point(150, 87);
            this.mlModel_Value.Name = "mlModel_Value";
            this.mlModel_Value.Size = new System.Drawing.Size(23, 15);
            this.mlModel_Value.TabIndex = 5;
            this.mlModel_Value.Text = "adf";
            // 
            // mlMediaType
            // 
            this.mlMediaType.AutoSize = true;
            this.mlMediaType.Location = new System.Drawing.Point(12, 115);
            this.mlMediaType.Name = "mlMediaType";
            this.mlMediaType.Size = new System.Drawing.Size(76, 19);
            this.mlMediaType.TabIndex = 6;
            this.mlMediaType.Text = "MediaType:";
            // 
            // mlMediaType_Value
            // 
            this.mlMediaType_Value.AutoSize = true;
            this.mlMediaType_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlMediaType_Value.Location = new System.Drawing.Point(150, 117);
            this.mlMediaType_Value.Name = "mlMediaType_Value";
            this.mlMediaType_Value.Size = new System.Drawing.Size(70, 15);
            this.mlMediaType_Value.TabIndex = 7;
            this.mlMediaType_Value.Text = "metroLabel6";
            // 
            // mlSerialNumber
            // 
            this.mlSerialNumber.AutoSize = true;
            this.mlSerialNumber.Location = new System.Drawing.Point(12, 145);
            this.mlSerialNumber.Name = "mlSerialNumber";
            this.mlSerialNumber.Size = new System.Drawing.Size(94, 19);
            this.mlSerialNumber.TabIndex = 8;
            this.mlSerialNumber.Text = "SerialNumber:";
            // 
            // mlSerialNumber_Value
            // 
            this.mlSerialNumber_Value.AutoSize = true;
            this.mlSerialNumber_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSerialNumber_Value.Location = new System.Drawing.Point(150, 147);
            this.mlSerialNumber_Value.Name = "mlSerialNumber_Value";
            this.mlSerialNumber_Value.Size = new System.Drawing.Size(70, 15);
            this.mlSerialNumber_Value.TabIndex = 9;
            this.mlSerialNumber_Value.Text = "metroLabel8";
            // 
            // mlInterfaceType
            // 
            this.mlInterfaceType.AutoSize = true;
            this.mlInterfaceType.Location = new System.Drawing.Point(12, 175);
            this.mlInterfaceType.Name = "mlInterfaceType";
            this.mlInterfaceType.Size = new System.Drawing.Size(89, 19);
            this.mlInterfaceType.TabIndex = 10;
            this.mlInterfaceType.Text = "InterfaceType:";
            // 
            // mlPartition
            // 
            this.mlPartition.AutoSize = true;
            this.mlPartition.Location = new System.Drawing.Point(12, 235);
            this.mlPartition.Name = "mlPartition";
            this.mlPartition.Size = new System.Drawing.Size(66, 19);
            this.mlPartition.TabIndex = 11;
            this.mlPartition.Text = "Partitions:";
            // 
            // mlSize
            // 
            this.mlSize.AutoSize = true;
            this.mlSize.Location = new System.Drawing.Point(12, 205);
            this.mlSize.Name = "mlSize";
            this.mlSize.Size = new System.Drawing.Size(35, 19);
            this.mlSize.TabIndex = 12;
            this.mlSize.Text = "Size:";
            // 
            // mlSignature
            // 
            this.mlSignature.AutoSize = true;
            this.mlSignature.Location = new System.Drawing.Point(12, 265);
            this.mlSignature.Name = "mlSignature";
            this.mlSignature.Size = new System.Drawing.Size(67, 19);
            this.mlSignature.TabIndex = 13;
            this.mlSignature.Text = "Signature:";
            // 
            // mlFirmwareRevision
            // 
            this.mlFirmwareRevision.AutoSize = true;
            this.mlFirmwareRevision.Location = new System.Drawing.Point(12, 295);
            this.mlFirmwareRevision.Name = "mlFirmwareRevision";
            this.mlFirmwareRevision.Size = new System.Drawing.Size(114, 19);
            this.mlFirmwareRevision.TabIndex = 14;
            this.mlFirmwareRevision.Text = "FirmwareRevision:";
            // 
            // mlFirmware_Value
            // 
            this.mlFirmware_Value.AutoSize = true;
            this.mlFirmware_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlFirmware_Value.Location = new System.Drawing.Point(150, 297);
            this.mlFirmware_Value.Name = "mlFirmware_Value";
            this.mlFirmware_Value.Size = new System.Drawing.Size(74, 15);
            this.mlFirmware_Value.TabIndex = 15;
            this.mlFirmware_Value.Text = "metroLabel14";
            // 
            // mlSize_Value
            // 
            this.mlSize_Value.AutoSize = true;
            this.mlSize_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSize_Value.Location = new System.Drawing.Point(150, 207);
            this.mlSize_Value.Name = "mlSize_Value";
            this.mlSize_Value.Size = new System.Drawing.Size(70, 15);
            this.mlSize_Value.TabIndex = 16;
            this.mlSize_Value.Text = "metroLabel3";
            // 
            // mlPartitions_Value
            // 
            this.mlPartitions_Value.AutoSize = true;
            this.mlPartitions_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlPartitions_Value.Location = new System.Drawing.Point(150, 237);
            this.mlPartitions_Value.Name = "mlPartitions_Value";
            this.mlPartitions_Value.Size = new System.Drawing.Size(70, 15);
            this.mlPartitions_Value.TabIndex = 17;
            this.mlPartitions_Value.Text = "metroLabel4";
            // 
            // mlSignature_Value
            // 
            this.mlSignature_Value.AutoSize = true;
            this.mlSignature_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSignature_Value.Location = new System.Drawing.Point(150, 267);
            this.mlSignature_Value.Name = "mlSignature_Value";
            this.mlSignature_Value.Size = new System.Drawing.Size(74, 15);
            this.mlSignature_Value.TabIndex = 18;
            this.mlSignature_Value.Text = "metroLabel15";
            // 
            // mlTotalCylinders
            // 
            this.mlTotalCylinders.AutoSize = true;
            this.mlTotalCylinders.Location = new System.Drawing.Point(12, 325);
            this.mlTotalCylinders.Name = "mlTotalCylinders";
            this.mlTotalCylinders.Size = new System.Drawing.Size(92, 19);
            this.mlTotalCylinders.TabIndex = 19;
            this.mlTotalCylinders.Text = "TotalCylinders:";
            // 
            // mlCylinders_Value
            // 
            this.mlCylinders_Value.AutoSize = true;
            this.mlCylinders_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCylinders_Value.Location = new System.Drawing.Point(150, 327);
            this.mlCylinders_Value.Name = "mlCylinders_Value";
            this.mlCylinders_Value.Size = new System.Drawing.Size(70, 15);
            this.mlCylinders_Value.TabIndex = 20;
            this.mlCylinders_Value.Text = "metroLabel3";
            // 
            // mlTotalSectors
            // 
            this.mlTotalSectors.AutoSize = true;
            this.mlTotalSectors.Location = new System.Drawing.Point(12, 355);
            this.mlTotalSectors.Name = "mlTotalSectors";
            this.mlTotalSectors.Size = new System.Drawing.Size(81, 19);
            this.mlTotalSectors.TabIndex = 21;
            this.mlTotalSectors.Text = "TotalSectors:";
            // 
            // mlSectors_Value
            // 
            this.mlSectors_Value.AutoSize = true;
            this.mlSectors_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSectors_Value.Location = new System.Drawing.Point(150, 357);
            this.mlSectors_Value.Name = "mlSectors_Value";
            this.mlSectors_Value.Size = new System.Drawing.Size(70, 15);
            this.mlSectors_Value.TabIndex = 22;
            this.mlSectors_Value.Text = "metroLabel6";
            // 
            // mlTotalHeads
            // 
            this.mlTotalHeads.AutoSize = true;
            this.mlTotalHeads.Location = new System.Drawing.Point(330, 85);
            this.mlTotalHeads.Name = "mlTotalHeads";
            this.mlTotalHeads.Size = new System.Drawing.Size(75, 19);
            this.mlTotalHeads.TabIndex = 23;
            this.mlTotalHeads.Text = "TotalHeads:";
            // 
            // mlHeads_Value
            // 
            this.mlHeads_Value.AutoSize = true;
            this.mlHeads_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlHeads_Value.Location = new System.Drawing.Point(448, 87);
            this.mlHeads_Value.Name = "mlHeads_Value";
            this.mlHeads_Value.Size = new System.Drawing.Size(70, 15);
            this.mlHeads_Value.TabIndex = 24;
            this.mlHeads_Value.Text = "metroLabel2";
            // 
            // mlTracks_Value
            // 
            this.mlTracks_Value.AutoSize = true;
            this.mlTracks_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlTracks_Value.Location = new System.Drawing.Point(448, 117);
            this.mlTracks_Value.Name = "mlTracks_Value";
            this.mlTracks_Value.Size = new System.Drawing.Size(70, 15);
            this.mlTracks_Value.TabIndex = 25;
            this.mlTracks_Value.Text = "metroLabel3";
            // 
            // mlTotalTracks
            // 
            this.mlTotalTracks.AutoSize = true;
            this.mlTotalTracks.Location = new System.Drawing.Point(330, 115);
            this.mlTotalTracks.Name = "mlTotalTracks";
            this.mlTotalTracks.Size = new System.Drawing.Size(73, 19);
            this.mlTotalTracks.TabIndex = 26;
            this.mlTotalTracks.Text = "TotalTracks:";
            // 
            // mlBytesPerSector
            // 
            this.mlBytesPerSector.AutoSize = true;
            this.mlBytesPerSector.Location = new System.Drawing.Point(330, 145);
            this.mlBytesPerSector.Name = "mlBytesPerSector";
            this.mlBytesPerSector.Size = new System.Drawing.Size(99, 19);
            this.mlBytesPerSector.TabIndex = 27;
            this.mlBytesPerSector.Text = "BytesPerSector:";
            // 
            // mlBytesPerSector_Value
            // 
            this.mlBytesPerSector_Value.AutoSize = true;
            this.mlBytesPerSector_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlBytesPerSector_Value.Location = new System.Drawing.Point(448, 147);
            this.mlBytesPerSector_Value.Name = "mlBytesPerSector_Value";
            this.mlBytesPerSector_Value.Size = new System.Drawing.Size(68, 15);
            this.mlBytesPerSector_Value.TabIndex = 28;
            this.mlBytesPerSector_Value.Text = "metroLabel1";
            // 
            // mlSectorsPerTrack
            // 
            this.mlSectorsPerTrack.AutoSize = true;
            this.mlSectorsPerTrack.Location = new System.Drawing.Point(330, 175);
            this.mlSectorsPerTrack.Name = "mlSectorsPerTrack";
            this.mlSectorsPerTrack.Size = new System.Drawing.Size(102, 19);
            this.mlSectorsPerTrack.TabIndex = 29;
            this.mlSectorsPerTrack.Text = "SectorsPerTrack:";
            // 
            // mlTracksPerCylinder
            // 
            this.mlTracksPerCylinder.AutoSize = true;
            this.mlTracksPerCylinder.Location = new System.Drawing.Point(330, 205);
            this.mlTracksPerCylinder.Name = "mlTracksPerCylinder";
            this.mlTracksPerCylinder.Size = new System.Drawing.Size(114, 19);
            this.mlTracksPerCylinder.TabIndex = 30;
            this.mlTracksPerCylinder.Text = "TracksPerCylinder:";
            // 
            // mlSectorsPerTrack_Value
            // 
            this.mlSectorsPerTrack_Value.AutoSize = true;
            this.mlSectorsPerTrack_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSectorsPerTrack_Value.Location = new System.Drawing.Point(448, 177);
            this.mlSectorsPerTrack_Value.Name = "mlSectorsPerTrack_Value";
            this.mlSectorsPerTrack_Value.Size = new System.Drawing.Size(70, 15);
            this.mlSectorsPerTrack_Value.TabIndex = 31;
            this.mlSectorsPerTrack_Value.Text = "metroLabel3";
            // 
            // mlTracksPerCylinder_Value
            // 
            this.mlTracksPerCylinder_Value.AutoSize = true;
            this.mlTracksPerCylinder_Value.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlTracksPerCylinder_Value.Location = new System.Drawing.Point(448, 207);
            this.mlTracksPerCylinder_Value.Name = "mlTracksPerCylinder_Value";
            this.mlTracksPerCylinder_Value.Size = new System.Drawing.Size(70, 15);
            this.mlTracksPerCylinder_Value.TabIndex = 32;
            this.mlTracksPerCylinder_Value.Text = "metroLabel4";
            // 
            // FormDatenträger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.mlTracksPerCylinder_Value);
            this.Controls.Add(this.mlSectorsPerTrack_Value);
            this.Controls.Add(this.mlTracksPerCylinder);
            this.Controls.Add(this.mlSectorsPerTrack);
            this.Controls.Add(this.mlBytesPerSector_Value);
            this.Controls.Add(this.mlBytesPerSector);
            this.Controls.Add(this.mlTotalTracks);
            this.Controls.Add(this.mlTracks_Value);
            this.Controls.Add(this.mlHeads_Value);
            this.Controls.Add(this.mlTotalHeads);
            this.Controls.Add(this.mlSectors_Value);
            this.Controls.Add(this.mlTotalSectors);
            this.Controls.Add(this.mlCylinders_Value);
            this.Controls.Add(this.mlTotalCylinders);
            this.Controls.Add(this.mlSignature_Value);
            this.Controls.Add(this.mlPartitions_Value);
            this.Controls.Add(this.mlSize_Value);
            this.Controls.Add(this.mlFirmware_Value);
            this.Controls.Add(this.mlFirmwareRevision);
            this.Controls.Add(this.mlSignature);
            this.Controls.Add(this.mlSize);
            this.Controls.Add(this.mlPartition);
            this.Controls.Add(this.mlInterfaceType);
            this.Controls.Add(this.mlSerialNumber_Value);
            this.Controls.Add(this.mlSerialNumber);
            this.Controls.Add(this.mlMediaType_Value);
            this.Controls.Add(this.mlMediaType);
            this.Controls.Add(this.mlModel_Value);
            this.Controls.Add(this.mlModel);
            this.Controls.Add(this.mlInterfaceType_Value);
            this.Controls.Add(this.combox_Datenträger);
            this.Controls.Add(this.mlFormDatenträger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatenträger";
            this.Text = "FormDatenträger";
            this.Load += new System.EventHandler(this.FormDatenträger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlFormDatenträger;
        private MetroFramework.Controls.MetroComboBox combox_Datenträger;
        private MetroFramework.Controls.MetroLabel mlInterfaceType_Value;
        private MetroFramework.Controls.MetroLabel mlModel;
        private MetroFramework.Controls.MetroLabel mlModel_Value;
        private MetroFramework.Controls.MetroLabel mlMediaType;
        private MetroFramework.Controls.MetroLabel mlMediaType_Value;
        private MetroFramework.Controls.MetroLabel mlSerialNumber;
        private MetroFramework.Controls.MetroLabel mlSerialNumber_Value;
        private MetroFramework.Controls.MetroLabel mlInterfaceType;
        private MetroFramework.Controls.MetroLabel mlPartition;
        private MetroFramework.Controls.MetroLabel mlSize;
        private MetroFramework.Controls.MetroLabel mlSignature;
        private MetroFramework.Controls.MetroLabel mlFirmwareRevision;
        private MetroFramework.Controls.MetroLabel mlFirmware_Value;
        private MetroFramework.Controls.MetroLabel mlSize_Value;
        private MetroFramework.Controls.MetroLabel mlPartitions_Value;
        private MetroFramework.Controls.MetroLabel mlSignature_Value;
        private MetroFramework.Controls.MetroLabel mlTotalCylinders;
        private MetroFramework.Controls.MetroLabel mlCylinders_Value;
        private MetroFramework.Controls.MetroLabel mlTotalSectors;
        private MetroFramework.Controls.MetroLabel mlSectors_Value;
        private MetroFramework.Controls.MetroLabel mlTotalHeads;
        private MetroFramework.Controls.MetroLabel mlHeads_Value;
        private MetroFramework.Controls.MetroLabel mlTracks_Value;
        private MetroFramework.Controls.MetroLabel mlTotalTracks;
        private MetroFramework.Controls.MetroLabel mlBytesPerSector;
        private MetroFramework.Controls.MetroLabel mlBytesPerSector_Value;
        private MetroFramework.Controls.MetroLabel mlSectorsPerTrack;
        private MetroFramework.Controls.MetroLabel mlTracksPerCylinder;
        private MetroFramework.Controls.MetroLabel mlSectorsPerTrack_Value;
        private MetroFramework.Controls.MetroLabel mlTracksPerCylinder_Value;
    }
}