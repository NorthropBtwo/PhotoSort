namespace Fotosort
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
            this.cmdSelCam1 = new System.Windows.Forms.Button();
            this.cmdSelCam2 = new System.Windows.Forms.Button();
            this.cmdSelCam3 = new System.Windows.Forms.Button();
            this.cobFilterCamera1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdStartSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdStartConstant = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdStartByKnown = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cobFilterCamera2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cobFilterCamera3 = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.toolStripInstruction = new System.Windows.Forms.ToolStripButton();
            this.windows7ProgressBar1 = new wyDay.Controls.Windows7ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "start index:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "filter file type:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(16, 37);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(149, 20);
            this.txtPrefix.TabIndex = 1;
            this.txtPrefix.Text = "Holiday";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(172, 37);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(100, 20);
            this.txtStartIndex.TabIndex = 2;
            this.txtStartIndex.Text = "0000";
            // 
            // txtFiler
            // 
            this.txtFiler.Location = new System.Drawing.Point(279, 37);
            this.txtFiler.Name = "txtFiler";
            this.txtFiler.Size = new System.Drawing.Size(108, 20);
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
            this.txtAddConstant_Y.Location = new System.Drawing.Point(16, 41);
            this.txtAddConstant_Y.Name = "txtAddConstant_Y";
            this.txtAddConstant_Y.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_Y.TabIndex = 5;
            this.txtAddConstant_Y.Text = "0";
            // 
            // txtAddConstant_Mon
            // 
            this.txtAddConstant_Mon.Location = new System.Drawing.Point(48, 41);
            this.txtAddConstant_Mon.Name = "txtAddConstant_Mon";
            this.txtAddConstant_Mon.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_Mon.TabIndex = 6;
            this.txtAddConstant_Mon.Text = "0";
            // 
            // txtAddConstant_D
            // 
            this.txtAddConstant_D.Location = new System.Drawing.Point(80, 41);
            this.txtAddConstant_D.Name = "txtAddConstant_D";
            this.txtAddConstant_D.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_D.TabIndex = 7;
            this.txtAddConstant_D.Text = "0";
            // 
            // txtAddConstant_h
            // 
            this.txtAddConstant_h.Location = new System.Drawing.Point(134, 41);
            this.txtAddConstant_h.Name = "txtAddConstant_h";
            this.txtAddConstant_h.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_h.TabIndex = 8;
            this.txtAddConstant_h.Text = "0";
            // 
            // txtAddConstant_min
            // 
            this.txtAddConstant_min.Location = new System.Drawing.Point(166, 41);
            this.txtAddConstant_min.Name = "txtAddConstant_min";
            this.txtAddConstant_min.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_min.TabIndex = 9;
            this.txtAddConstant_min.Text = "0";
            // 
            // txtAddConstant_s
            // 
            this.txtAddConstant_s.Location = new System.Drawing.Point(198, 41);
            this.txtAddConstant_s.Name = "txtAddConstant_s";
            this.txtAddConstant_s.Size = new System.Drawing.Size(26, 20);
            this.txtAddConstant_s.TabIndex = 10;
            this.txtAddConstant_s.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "M:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "h:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "m:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "s:";
            // 
            // cmdSelectImage
            // 
            this.cmdSelectImage.Location = new System.Drawing.Point(16, 34);
            this.cmdSelectImage.Name = "cmdSelectImage";
            this.cmdSelectImage.Size = new System.Drawing.Size(91, 23);
            this.cmdSelectImage.TabIndex = 13;
            this.cmdSelectImage.Text = "select image";
            this.cmdSelectImage.UseVisualStyleBackColor = true;
            this.cmdSelectImage.Click += new System.EventHandler(this.cmdSelectImage_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "filter file type:";
            // 
            // txtFiler2
            // 
            this.txtFiler2.Location = new System.Drawing.Point(277, 41);
            this.txtFiler2.Name = "txtFiler2";
            this.txtFiler2.Size = new System.Drawing.Size(108, 20);
            this.txtFiler2.TabIndex = 11;
            this.txtFiler2.Text = ".jpg|.jpeg";
            // 
            // txtFiler3
            // 
            this.txtFiler3.Location = new System.Drawing.Point(279, 36);
            this.txtFiler3.Name = "txtFiler3";
            this.txtFiler3.Size = new System.Drawing.Size(108, 20);
            this.txtFiler3.TabIndex = 15;
            this.txtFiler3.Text = ".jpg|.jpeg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "filter file type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(617, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 311);
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
            this.toolStripInstruction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(989, 28);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(25, 25);
            this.toolStripDropDownButton1.Text = "?";
            // 
            // ToolStripInfo
            // 
            this.ToolStripInfo.Name = "ToolStripInfo";
            this.ToolStripInfo.Size = new System.Drawing.Size(95, 22);
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
            this.cmdUpdate.Size = new System.Drawing.Size(115, 25);
            this.cmdUpdate.Text = "update ready";
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdSelCam1
            // 
            this.cmdSelCam1.Location = new System.Drawing.Point(393, 64);
            this.cmdSelCam1.Name = "cmdSelCam1";
            this.cmdSelCam1.Size = new System.Drawing.Size(91, 23);
            this.cmdSelCam1.TabIndex = 35;
            this.cmdSelCam1.Text = "scan cameras";
            this.cmdSelCam1.UseVisualStyleBackColor = true;
            this.cmdSelCam1.Click += new System.EventHandler(this.cmdSelCam1_Click);
            // 
            // cmdSelCam2
            // 
            this.cmdSelCam2.Location = new System.Drawing.Point(393, 67);
            this.cmdSelCam2.Name = "cmdSelCam2";
            this.cmdSelCam2.Size = new System.Drawing.Size(91, 23);
            this.cmdSelCam2.TabIndex = 36;
            this.cmdSelCam2.Text = "scan cameras";
            this.cmdSelCam2.UseVisualStyleBackColor = true;
            this.cmdSelCam2.Click += new System.EventHandler(this.cmdSelCam1_Click);
            // 
            // cmdSelCam3
            // 
            this.cmdSelCam3.Location = new System.Drawing.Point(393, 61);
            this.cmdSelCam3.Name = "cmdSelCam3";
            this.cmdSelCam3.Size = new System.Drawing.Size(91, 23);
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
            this.cobFilterCamera1.Location = new System.Drawing.Point(393, 37);
            this.cobFilterCamera1.Name = "cobFilterCamera1";
            this.cobFilterCamera1.Size = new System.Drawing.Size(159, 21);
            this.cobFilterCamera1.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 102);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort photos by time taken";
            // 
            // cmdStartSort
            // 
            this.cmdStartSort.Location = new System.Drawing.Point(16, 65);
            this.cmdStartSort.Name = "cmdStartSort";
            this.cmdStartSort.Size = new System.Drawing.Size(128, 23);
            this.cmdStartSort.TabIndex = 42;
            this.cmdStartSort.Text = "start";
            this.cmdStartSort.UseVisualStyleBackColor = true;
            this.cmdStartSort.Click += new System.EventHandler(this.cmdStartSort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmdStartConstant);
            this.groupBox2.Controls.Add(this.cobFilterCamera2);
            this.groupBox2.Controls.Add(this.cmdSelCam2);
            this.groupBox2.Controls.Add(this.txtAddConstant_Y);
            this.groupBox2.Controls.Add(this.txtAddConstant_Mon);
            this.groupBox2.Controls.Add(this.txtAddConstant_D);
            this.groupBox2.Controls.Add(this.txtAddConstant_h);
            this.groupBox2.Controls.Add(this.txtAddConstant_min);
            this.groupBox2.Controls.Add(this.txtAddConstant_s);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFiler2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(25, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 102);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add constant time span to captured time";
            // 
            // cmdStartConstant
            // 
            this.cmdStartConstant.Location = new System.Drawing.Point(16, 68);
            this.cmdStartConstant.Name = "cmdStartConstant";
            this.cmdStartConstant.Size = new System.Drawing.Size(128, 23);
            this.cmdStartConstant.TabIndex = 43;
            this.cmdStartConstant.Text = "start";
            this.cmdStartConstant.UseVisualStyleBackColor = true;
            this.cmdStartConstant.Click += new System.EventHandler(this.cmdStartConstant_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmdStartByKnown);
            this.groupBox3.Controls.Add(this.cobFilterCamera3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.cmdSelectImage);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFiler3);
            this.groupBox3.Controls.Add(this.cmdSelCam3);
            this.groupBox3.Location = new System.Drawing.Point(25, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 102);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "correct captured time by known image";
            // 
            // cmdStartByKnown
            // 
            this.cmdStartByKnown.Location = new System.Drawing.Point(17, 66);
            this.cmdStartByKnown.Name = "cmdStartByKnown";
            this.cmdStartByKnown.Size = new System.Drawing.Size(128, 23);
            this.cmdStartByKnown.TabIndex = 44;
            this.cmdStartByKnown.Text = "start";
            this.cmdStartByKnown.UseVisualStyleBackColor = true;
            this.cmdStartByKnown.Click += new System.EventHandler(this.cmdStartByKnown_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "filter camera:";
            // 
            // cobFilterCamera2
            // 
            this.cobFilterCamera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterCamera2.Enabled = false;
            this.cobFilterCamera2.FormattingEnabled = true;
            this.cobFilterCamera2.Items.AddRange(new object[] {
            "all"});
            this.cobFilterCamera2.Location = new System.Drawing.Point(393, 40);
            this.cobFilterCamera2.Name = "cobFilterCamera2";
            this.cobFilterCamera2.Size = new System.Drawing.Size(159, 21);
            this.cobFilterCamera2.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "filter camera:";
            // 
            // cobFilterCamera3
            // 
            this.cobFilterCamera3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterCamera3.Enabled = false;
            this.cobFilterCamera3.FormattingEnabled = true;
            this.cobFilterCamera3.Items.AddRange(new object[] {
            "all"});
            this.cobFilterCamera3.Location = new System.Drawing.Point(393, 34);
            this.cobFilterCamera3.Name = "cobFilterCamera3";
            this.cobFilterCamera3.Size = new System.Drawing.Size(159, 21);
            this.cobFilterCamera3.TabIndex = 45;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancel.Location = new System.Drawing.Point(444, 362);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 40);
            this.cmdCancel.TabIndex = 47;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // toolStripInstruction
            // 
            this.toolStripInstruction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInstruction.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInstruction.Image")));
            this.toolStripInstruction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInstruction.Name = "toolStripInstruction";
            this.toolStripInstruction.Size = new System.Drawing.Size(68, 25);
            this.toolStripInstruction.Text = "Instruction";
            this.toolStripInstruction.Click += new System.EventHandler(this.toolStripInstruction_Click);
            // 
            // windows7ProgressBar1
            // 
            this.windows7ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windows7ProgressBar1.ContainerControl = this;
            this.windows7ProgressBar1.Location = new System.Drawing.Point(13, 408);
            this.windows7ProgressBar1.Name = "windows7ProgressBar1";
            this.windows7ProgressBar1.ShowInTaskbar = true;
            this.windows7ProgressBar1.Size = new System.Drawing.Size(964, 23);
            this.windows7ProgressBar1.TabIndex = 34;
            // 
            // frmPhotoSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(989, 441);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.windows7ProgressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPhotoSort";
            this.Text = "PhotoSort";
            this.Load += new System.EventHandler(this.frmFotoSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStartConstant;
        private System.Windows.Forms.Button cmdStartByKnown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cobFilterCamera2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cobFilterCamera3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ToolStripButton toolStripInstruction;
    }
}