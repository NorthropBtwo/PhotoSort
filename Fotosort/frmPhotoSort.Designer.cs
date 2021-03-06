﻿namespace Fotosort
{
    partial class frmPhotoSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoSort));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtFiler = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAddConstant_Y = new System.Windows.Forms.TextBox();
            this.txtAddConstant_Mon = new System.Windows.Forms.TextBox();
            this.txtAddConstant_D = new System.Windows.Forms.TextBox();
            this.txtAddConstant_h = new System.Windows.Forms.TextBox();
            this.txtAddConstant_min = new System.Windows.Forms.TextBox();
            this.txtAddConstant_s = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdSelectImage = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiler2 = new System.Windows.Forms.TextBox();
            this.txtFiler3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripInstruction = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripChangeDir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLblPhotoDir = new System.Windows.Forms.ToolStripLabel();
            this.cmdSelCam1 = new System.Windows.Forms.Button();
            this.cmdSelCam2 = new System.Windows.Forms.Button();
            this.cmdSelCam3 = new System.Windows.Forms.Button();
            this.cobFilterCamera1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdShowModifyCaptureTime = new System.Windows.Forms.Button();
            this.cmdStartSort = new System.Windows.Forms.Button();
            this.grpbox_addTime = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdStartConstant = new System.Windows.Forms.Button();
            this.cobFilterCamera2 = new System.Windows.Forms.ComboBox();
            this.grpbox_setTimeByKnown = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdStartByKnown = new System.Windows.Forms.Button();
            this.cobFilterCamera3 = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.windows7ProgressBar1 = new wyDay.Controls.Windows7ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbox_addTime.SuspendLayout();
            this.grpbox_setTimeByKnown.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "start index:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "filter file type:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(20, 46);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(185, 23);
            this.txtPrefix.TabIndex = 1;
            this.txtPrefix.Text = "Holiday";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(215, 46);
            this.txtStartIndex.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(124, 23);
            this.txtStartIndex.TabIndex = 2;
            this.txtStartIndex.Text = "0000";
            // 
            // txtFiler
            // 
            this.txtFiler.Location = new System.Drawing.Point(349, 46);
            this.txtFiler.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler.Name = "txtFiler";
            this.txtFiler.Size = new System.Drawing.Size(134, 23);
            this.txtFiler.TabIndex = 3;
            this.txtFiler.Text = ".jpg|.jpeg";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtAddConstant_Y
            // 
            this.txtAddConstant_Y.Location = new System.Drawing.Point(20, 51);
            this.txtAddConstant_Y.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_Y.Name = "txtAddConstant_Y";
            this.txtAddConstant_Y.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_Y.TabIndex = 5;
            this.txtAddConstant_Y.Text = "0";
            // 
            // txtAddConstant_Mon
            // 
            this.txtAddConstant_Mon.Location = new System.Drawing.Point(60, 51);
            this.txtAddConstant_Mon.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_Mon.Name = "txtAddConstant_Mon";
            this.txtAddConstant_Mon.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_Mon.TabIndex = 6;
            this.txtAddConstant_Mon.Text = "0";
            // 
            // txtAddConstant_D
            // 
            this.txtAddConstant_D.Location = new System.Drawing.Point(100, 51);
            this.txtAddConstant_D.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_D.Name = "txtAddConstant_D";
            this.txtAddConstant_D.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_D.TabIndex = 7;
            this.txtAddConstant_D.Text = "0";
            // 
            // txtAddConstant_h
            // 
            this.txtAddConstant_h.Location = new System.Drawing.Point(168, 51);
            this.txtAddConstant_h.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_h.Name = "txtAddConstant_h";
            this.txtAddConstant_h.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_h.TabIndex = 8;
            this.txtAddConstant_h.Text = "0";
            // 
            // txtAddConstant_min
            // 
            this.txtAddConstant_min.Location = new System.Drawing.Point(208, 51);
            this.txtAddConstant_min.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_min.Name = "txtAddConstant_min";
            this.txtAddConstant_min.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_min.TabIndex = 9;
            this.txtAddConstant_min.Text = "0";
            // 
            // txtAddConstant_s
            // 
            this.txtAddConstant_s.Location = new System.Drawing.Point(248, 51);
            this.txtAddConstant_s.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_s.Name = "txtAddConstant_s";
            this.txtAddConstant_s.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_s.TabIndex = 10;
            this.txtAddConstant_s.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "M:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "h:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "m:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "s:";
            // 
            // cmdSelectImage
            // 
            this.cmdSelectImage.Location = new System.Drawing.Point(20, 42);
            this.cmdSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectImage.Name = "cmdSelectImage";
            this.cmdSelectImage.Size = new System.Drawing.Size(114, 29);
            this.cmdSelectImage.TabIndex = 13;
            this.cmdSelectImage.Text = "select image";
            this.cmdSelectImage.UseVisualStyleBackColor = true;
            this.cmdSelectImage.Click += new System.EventHandler(this.cmdSelectImage_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 45);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "filter file type:";
            // 
            // txtFiler2
            // 
            this.txtFiler2.Location = new System.Drawing.Point(346, 51);
            this.txtFiler2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler2.Name = "txtFiler2";
            this.txtFiler2.Size = new System.Drawing.Size(134, 22);
            this.txtFiler2.TabIndex = 11;
            this.txtFiler2.Text = ".jpg|.jpeg";
            // 
            // txtFiler3
            // 
            this.txtFiler3.Location = new System.Drawing.Point(349, 45);
            this.txtFiler3.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler3.Name = "txtFiler3";
            this.txtFiler3.Size = new System.Drawing.Size(134, 22);
            this.txtFiler3.TabIndex = 15;
            this.txtFiler3.Text = ".jpg|.jpeg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "filter file type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(771, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.cmdUpdate,
            this.toolStripInstruction,
            this.toolStripSeparator1,
            this.toolStripChangeDir,
            this.toolStripLblPhotoDir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1236, 35);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInfo});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(30, 32);
            this.toolStripDropDownButton1.Text = "?";
            // 
            // ToolStripInfo
            // 
            this.ToolStripInfo.Name = "ToolStripInfo";
            this.ToolStripInfo.Size = new System.Drawing.Size(110, 26);
            this.ToolStripInfo.Text = "Info";
            this.ToolStripInfo.Click += new System.EventHandler(this.ToolStripInfo_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmdUpdate.ForeColor = System.Drawing.Color.ForestGreen;
            this.cmdUpdate.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpdate.Image")));
            this.cmdUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(141, 32);
            this.cmdUpdate.Text = "update ready";
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // toolStripInstruction
            // 
            this.toolStripInstruction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInstruction.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInstruction.Image")));
            this.toolStripInstruction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInstruction.Name = "toolStripInstruction";
            this.toolStripInstruction.Size = new System.Drawing.Size(82, 32);
            this.toolStripInstruction.Text = "Instruction";
            this.toolStripInstruction.Click += new System.EventHandler(this.toolStripInstruction_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripChangeDir
            // 
            this.toolStripChangeDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripChangeDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChangeDir.Name = "toolStripChangeDir";
            this.toolStripChangeDir.Size = new System.Drawing.Size(168, 32);
            this.toolStripChangeDir.Text = "Change photo location:";
            this.toolStripChangeDir.Click += new System.EventHandler(this.toolStripChangeDir_Click);
            // 
            // toolStripLblPhotoDir
            // 
            this.toolStripLblPhotoDir.Name = "toolStripLblPhotoDir";
            this.toolStripLblPhotoDir.Size = new System.Drawing.Size(125, 32);
            this.toolStripLblPhotoDir.Text = "working directory";
            this.toolStripLblPhotoDir.Click += new System.EventHandler(this.toolStripChangeDir_Click);
            // 
            // cmdSelCam1
            // 
            this.cmdSelCam1.Location = new System.Drawing.Point(491, 80);
            this.cmdSelCam1.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelCam1.Name = "cmdSelCam1";
            this.cmdSelCam1.Size = new System.Drawing.Size(114, 29);
            this.cmdSelCam1.TabIndex = 35;
            this.cmdSelCam1.Text = "scan cameras";
            this.cmdSelCam1.UseVisualStyleBackColor = true;
            this.cmdSelCam1.Click += new System.EventHandler(this.cmdSelCam1_Click);
            // 
            // cmdSelCam2
            // 
            this.cmdSelCam2.Location = new System.Drawing.Point(491, 84);
            this.cmdSelCam2.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelCam2.Name = "cmdSelCam2";
            this.cmdSelCam2.Size = new System.Drawing.Size(114, 29);
            this.cmdSelCam2.TabIndex = 36;
            this.cmdSelCam2.Text = "scan cameras";
            this.cmdSelCam2.UseVisualStyleBackColor = true;
            this.cmdSelCam2.Click += new System.EventHandler(this.cmdSelCam1_Click);
            // 
            // cmdSelCam3
            // 
            this.cmdSelCam3.Location = new System.Drawing.Point(491, 76);
            this.cmdSelCam3.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelCam3.Name = "cmdSelCam3";
            this.cmdSelCam3.Size = new System.Drawing.Size(114, 29);
            this.cmdSelCam3.TabIndex = 37;
            this.cmdSelCam3.Text = "scan cameras";
            this.cmdSelCam3.UseVisualStyleBackColor = true;
            this.cmdSelCam3.Click += new System.EventHandler(this.cmdSelCam1_Click);
            // 
            // cobFilterCamera1
            // 
            this.cobFilterCamera1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterCamera1.Enabled = false;
            this.cobFilterCamera1.FormattingEnabled = true;
            this.cobFilterCamera1.Items.AddRange(new object[] {
            "all"});
            this.cobFilterCamera1.Location = new System.Drawing.Point(491, 46);
            this.cobFilterCamera1.Margin = new System.Windows.Forms.Padding(4);
            this.cobFilterCamera1.Name = "cobFilterCamera1";
            this.cobFilterCamera1.Size = new System.Drawing.Size(198, 25);
            this.cobFilterCamera1.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "filter camera:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdStartSort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobFilterCamera1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrefix);
            this.groupBox1.Controls.Add(this.txtStartIndex);
            this.groupBox1.Controls.Add(this.txtFiler);
            this.groupBox1.Controls.Add(this.cmdSelCam1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(720, 128);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort photos by capture time";
            // 
            // cmdShowModifyCaptureTime
            // 
            this.cmdShowModifyCaptureTime.Location = new System.Drawing.Point(50, 212);
            this.cmdShowModifyCaptureTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmdShowModifyCaptureTime.Name = "cmdShowModifyCaptureTime";
            this.cmdShowModifyCaptureTime.Size = new System.Drawing.Size(160, 29);
            this.cmdShowModifyCaptureTime.TabIndex = 43;
            this.cmdShowModifyCaptureTime.Text = "modify capture time";
            this.cmdShowModifyCaptureTime.UseVisualStyleBackColor = true;
            this.cmdShowModifyCaptureTime.Click += new System.EventHandler(this.cmdShowModifyCaptureTime_Click);
            // 
            // cmdStartSort
            // 
            this.cmdStartSort.Location = new System.Drawing.Point(20, 81);
            this.cmdStartSort.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStartSort.Name = "cmdStartSort";
            this.cmdStartSort.Size = new System.Drawing.Size(160, 29);
            this.cmdStartSort.TabIndex = 42;
            this.cmdStartSort.Text = "start";
            this.cmdStartSort.UseVisualStyleBackColor = true;
            this.cmdStartSort.Click += new System.EventHandler(this.cmdStartSort_Click);
            // 
            // grpbox_addTime
            // 
            this.grpbox_addTime.Controls.Add(this.label13);
            this.grpbox_addTime.Controls.Add(this.cmdStartConstant);
            this.grpbox_addTime.Controls.Add(this.cobFilterCamera2);
            this.grpbox_addTime.Controls.Add(this.cmdSelCam2);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_Y);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_Mon);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_D);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_h);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_min);
            this.grpbox_addTime.Controls.Add(this.txtAddConstant_s);
            this.grpbox_addTime.Controls.Add(this.label4);
            this.grpbox_addTime.Controls.Add(this.label5);
            this.grpbox_addTime.Controls.Add(this.label6);
            this.grpbox_addTime.Controls.Add(this.label7);
            this.grpbox_addTime.Controls.Add(this.label8);
            this.grpbox_addTime.Controls.Add(this.label9);
            this.grpbox_addTime.Controls.Add(this.txtFiler2);
            this.grpbox_addTime.Controls.Add(this.label10);
            this.grpbox_addTime.Location = new System.Drawing.Point(31, 185);
            this.grpbox_addTime.Margin = new System.Windows.Forms.Padding(4);
            this.grpbox_addTime.Name = "grpbox_addTime";
            this.grpbox_addTime.Padding = new System.Windows.Forms.Padding(4);
            this.grpbox_addTime.Size = new System.Drawing.Size(720, 128);
            this.grpbox_addTime.TabIndex = 42;
            this.grpbox_addTime.TabStop = false;
            this.grpbox_addTime.Text = "Add constant time span to captured time";
            this.grpbox_addTime.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "filter camera:";
            // 
            // cmdStartConstant
            // 
            this.cmdStartConstant.Location = new System.Drawing.Point(20, 85);
            this.cmdStartConstant.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStartConstant.Name = "cmdStartConstant";
            this.cmdStartConstant.Size = new System.Drawing.Size(160, 29);
            this.cmdStartConstant.TabIndex = 43;
            this.cmdStartConstant.Text = "start";
            this.cmdStartConstant.UseVisualStyleBackColor = true;
            this.cmdStartConstant.Click += new System.EventHandler(this.cmdStartConstant_Click);
            // 
            // cobFilterCamera2
            // 
            this.cobFilterCamera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterCamera2.Enabled = false;
            this.cobFilterCamera2.FormattingEnabled = true;
            this.cobFilterCamera2.Items.AddRange(new object[] {
            "all"});
            this.cobFilterCamera2.Location = new System.Drawing.Point(491, 50);
            this.cobFilterCamera2.Margin = new System.Windows.Forms.Padding(4);
            this.cobFilterCamera2.Name = "cobFilterCamera2";
            this.cobFilterCamera2.Size = new System.Drawing.Size(198, 24);
            this.cobFilterCamera2.TabIndex = 43;
            // 
            // grpbox_setTimeByKnown
            // 
            this.grpbox_setTimeByKnown.Controls.Add(this.label14);
            this.grpbox_setTimeByKnown.Controls.Add(this.cmdStartByKnown);
            this.grpbox_setTimeByKnown.Controls.Add(this.cobFilterCamera3);
            this.grpbox_setTimeByKnown.Controls.Add(this.dateTimePicker1);
            this.grpbox_setTimeByKnown.Controls.Add(this.cmdSelectImage);
            this.grpbox_setTimeByKnown.Controls.Add(this.label11);
            this.grpbox_setTimeByKnown.Controls.Add(this.txtFiler3);
            this.grpbox_setTimeByKnown.Controls.Add(this.cmdSelCam3);
            this.grpbox_setTimeByKnown.Location = new System.Drawing.Point(31, 320);
            this.grpbox_setTimeByKnown.Margin = new System.Windows.Forms.Padding(4);
            this.grpbox_setTimeByKnown.Name = "grpbox_setTimeByKnown";
            this.grpbox_setTimeByKnown.Padding = new System.Windows.Forms.Padding(4);
            this.grpbox_setTimeByKnown.Size = new System.Drawing.Size(720, 128);
            this.grpbox_setTimeByKnown.TabIndex = 43;
            this.grpbox_setTimeByKnown.TabStop = false;
            this.grpbox_setTimeByKnown.Text = "Correct captured time by known image";
            this.grpbox_setTimeByKnown.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(488, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "filter camera:";
            // 
            // cmdStartByKnown
            // 
            this.cmdStartByKnown.Location = new System.Drawing.Point(21, 82);
            this.cmdStartByKnown.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStartByKnown.Name = "cmdStartByKnown";
            this.cmdStartByKnown.Size = new System.Drawing.Size(160, 29);
            this.cmdStartByKnown.TabIndex = 44;
            this.cmdStartByKnown.Text = "start";
            this.cmdStartByKnown.UseVisualStyleBackColor = true;
            this.cmdStartByKnown.Click += new System.EventHandler(this.cmdStartByKnown_Click);
            // 
            // cobFilterCamera3
            // 
            this.cobFilterCamera3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterCamera3.Enabled = false;
            this.cobFilterCamera3.FormattingEnabled = true;
            this.cobFilterCamera3.Items.AddRange(new object[] {
            "all"});
            this.cobFilterCamera3.Location = new System.Drawing.Point(491, 42);
            this.cobFilterCamera3.Margin = new System.Windows.Forms.Padding(4);
            this.cobFilterCamera3.Name = "cobFilterCamera3";
            this.cobFilterCamera3.Size = new System.Drawing.Size(198, 24);
            this.cobFilterCamera3.TabIndex = 45;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancel.Location = new System.Drawing.Point(555, 464);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(134, 50);
            this.cmdCancel.TabIndex = 47;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // windows7ProgressBar1
            // 
            this.windows7ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windows7ProgressBar1.ContainerControl = this;
            this.windows7ProgressBar1.Location = new System.Drawing.Point(16, 521);
            this.windows7ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.windows7ProgressBar1.Name = "windows7ProgressBar1";
            this.windows7ProgressBar1.ShowInTaskbar = true;
            this.windows7ProgressBar1.Size = new System.Drawing.Size(1205, 29);
            this.windows7ProgressBar1.TabIndex = 34;
            // 
            // frmPhotoSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1236, 562);
            this.Controls.Add(this.cmdShowModifyCaptureTime);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.grpbox_setTimeByKnown);
            this.Controls.Add(this.grpbox_addTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.windows7ProgressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhotoSort";
            this.Text = "PhotoSort";
            this.Load += new System.EventHandler(this.frmFotoSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_addTime.ResumeLayout(false);
            this.grpbox_addTime.PerformLayout();
            this.grpbox_setTimeByKnown.ResumeLayout(false);
            this.grpbox_setTimeByKnown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtFiler;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAddConstant_Y;
        private System.Windows.Forms.TextBox txtAddConstant_Mon;
        private System.Windows.Forms.TextBox txtAddConstant_D;
        private System.Windows.Forms.TextBox txtAddConstant_h;
        private System.Windows.Forms.TextBox txtAddConstant_min;
        private System.Windows.Forms.TextBox txtAddConstant_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdSelectImage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiler2;
        private System.Windows.Forms.TextBox txtFiler3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripInfo;
    private wyDay.Controls.Windows7ProgressBar windows7ProgressBar1;
        private System.Windows.Forms.ToolStripButton cmdUpdate;
        private System.Windows.Forms.Button cmdSelCam3;
        private System.Windows.Forms.Button cmdSelCam2;
        private System.Windows.Forms.Button cmdSelCam1;
        private System.Windows.Forms.ComboBox cobFilterCamera1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdStartSort;
        private System.Windows.Forms.GroupBox grpbox_setTimeByKnown;
        private System.Windows.Forms.GroupBox grpbox_addTime;
        private System.Windows.Forms.Button cmdStartConstant;
        private System.Windows.Forms.Button cmdStartByKnown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cobFilterCamera2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cobFilterCamera3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ToolStripButton toolStripInstruction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripChangeDir;
        private System.Windows.Forms.ToolStripLabel toolStripLblPhotoDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cmdShowModifyCaptureTime;
    }
}