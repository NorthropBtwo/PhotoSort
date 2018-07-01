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
            this.radSort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtFiler = new System.Windows.Forms.TextBox();
            this.progBarTask = new System.Windows.Forms.ProgressBar();
            this.cmdstart = new System.Windows.Forms.Button();
            this.cmdstart1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancel = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.radAddConstantTime = new System.Windows.Forms.RadioButton();
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
            this.radKnownImage = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSort
            // 
            this.radSort.AutoSize = true;
            this.radSort.Location = new System.Drawing.Point(29, 38);
            this.radSort.Margin = new System.Windows.Forms.Padding(4);
            this.radSort.Name = "radSort";
            this.radSort.Size = new System.Drawing.Size(183, 21);
            this.radSort.TabIndex = 0;
            this.radSort.TabStop = true;
            this.radSort.Text = "Sort photo by time taken";
            this.radSort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 75);
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
            this.label3.Location = new System.Drawing.Point(357, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "filter:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(29, 95);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(185, 22);
            this.txtPrefix.TabIndex = 4;
            this.txtPrefix.Text = "Holiday";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(224, 95);
            this.txtStartIndex.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(124, 22);
            this.txtStartIndex.TabIndex = 5;
            this.txtStartIndex.Text = "0000";
            // 
            // txtFiler
            // 
            this.txtFiler.Location = new System.Drawing.Point(357, 95);
            this.txtFiler.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler.Name = "txtFiler";
            this.txtFiler.Size = new System.Drawing.Size(185, 22);
            this.txtFiler.TabIndex = 6;
            this.txtFiler.Text = ".jpg|.jpeg";
            // 
            // progBarTask
            // 
            this.progBarTask.Location = new System.Drawing.Point(16, 526);
            this.progBarTask.Margin = new System.Windows.Forms.Padding(4);
            this.progBarTask.Name = "progBarTask";
            this.progBarTask.Size = new System.Drawing.Size(1061, 28);
            this.progBarTask.TabIndex = 7;
            // 
            // cmdstart
            // 
            this.cmdstart.Location = new System.Drawing.Point(16, 476);
            this.cmdstart.Margin = new System.Windows.Forms.Padding(4);
            this.cmdstart.Name = "cmdstart";
            this.cmdstart.Size = new System.Drawing.Size(221, 42);
            this.cmdstart.TabIndex = 8;
            this.cmdstart.Text = "start";
            this.cmdstart.UseVisualStyleBackColor = true;
            this.cmdstart.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // cmdstart1
            // 
            this.cmdstart1.Location = new System.Drawing.Point(856, 476);
            this.cmdstart1.Margin = new System.Windows.Forms.Padding(4);
            this.cmdstart1.Name = "cmdstart1";
            this.cmdstart1.Size = new System.Drawing.Size(221, 42);
            this.cmdstart1.TabIndex = 9;
            this.cmdstart1.Text = "start";
            this.cmdstart1.UseVisualStyleBackColor = true;
            this.cmdstart1.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancel
            // 
            this.cancel.Enabled = false;
            this.cancel.Location = new System.Drawing.Point(245, 476);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(221, 42);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cancel1
            // 
            this.cancel1.Enabled = false;
            this.cancel1.Location = new System.Drawing.Point(627, 476);
            this.cancel1.Margin = new System.Windows.Forms.Padding(4);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(221, 42);
            this.cancel1.TabIndex = 11;
            this.cancel1.Text = "cancel";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel_Click);
            // 
            // radAddConstantTime
            // 
            this.radAddConstantTime.AutoSize = true;
            this.radAddConstantTime.Location = new System.Drawing.Point(29, 166);
            this.radAddConstantTime.Margin = new System.Windows.Forms.Padding(4);
            this.radAddConstantTime.Name = "radAddConstantTime";
            this.radAddConstantTime.Size = new System.Drawing.Size(283, 21);
            this.radAddConstantTime.TabIndex = 12;
            this.radAddConstantTime.TabStop = true;
            this.radAddConstantTime.Text = "Add constant time span to captured time";
            this.radAddConstantTime.UseVisualStyleBackColor = true;
            // 
            // txtAddConstant_Y
            // 
            this.txtAddConstant_Y.Location = new System.Drawing.Point(31, 219);
            this.txtAddConstant_Y.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_Y.Name = "txtAddConstant_Y";
            this.txtAddConstant_Y.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_Y.TabIndex = 13;
            this.txtAddConstant_Y.Text = "0";
            // 
            // txtAddConstant_Mon
            // 
            this.txtAddConstant_Mon.Location = new System.Drawing.Point(71, 219);
            this.txtAddConstant_Mon.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_Mon.Name = "txtAddConstant_Mon";
            this.txtAddConstant_Mon.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_Mon.TabIndex = 14;
            this.txtAddConstant_Mon.Text = "0";
            // 
            // txtAddConstant_D
            // 
            this.txtAddConstant_D.Location = new System.Drawing.Point(111, 219);
            this.txtAddConstant_D.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_D.Name = "txtAddConstant_D";
            this.txtAddConstant_D.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_D.TabIndex = 15;
            this.txtAddConstant_D.Text = "0";
            // 
            // txtAddConstant_h
            // 
            this.txtAddConstant_h.Location = new System.Drawing.Point(179, 219);
            this.txtAddConstant_h.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_h.Name = "txtAddConstant_h";
            this.txtAddConstant_h.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_h.TabIndex = 16;
            this.txtAddConstant_h.Text = "0";
            // 
            // txtAddConstant_min
            // 
            this.txtAddConstant_min.Location = new System.Drawing.Point(219, 219);
            this.txtAddConstant_min.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_min.Name = "txtAddConstant_min";
            this.txtAddConstant_min.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_min.TabIndex = 17;
            this.txtAddConstant_min.Text = "0";
            // 
            // txtAddConstant_s
            // 
            this.txtAddConstant_s.Location = new System.Drawing.Point(259, 219);
            this.txtAddConstant_s.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddConstant_s.Name = "txtAddConstant_s";
            this.txtAddConstant_s.Size = new System.Drawing.Size(32, 22);
            this.txtAddConstant_s.TabIndex = 18;
            this.txtAddConstant_s.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "M:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "h:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "m:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "s:";
            // 
            // radKnownImage
            // 
            this.radKnownImage.AutoSize = true;
            this.radKnownImage.Location = new System.Drawing.Point(29, 299);
            this.radKnownImage.Margin = new System.Windows.Forms.Padding(4);
            this.radKnownImage.Name = "radKnownImage";
            this.radKnownImage.Size = new System.Drawing.Size(268, 21);
            this.radKnownImage.TabIndex = 27;
            this.radKnownImage.TabStop = true;
            this.radKnownImage.Text = "correct captured time by known image";
            this.radKnownImage.UseVisualStyleBackColor = true;
            // 
            // cmdSelectImage
            // 
            this.cmdSelectImage.Location = new System.Drawing.Point(29, 337);
            this.cmdSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectImage.Name = "cmdSelectImage";
            this.cmdSelectImage.Size = new System.Drawing.Size(114, 29);
            this.cmdSelectImage.TabIndex = 28;
            this.cmdSelectImage.Text = "select image";
            this.cmdSelectImage.UseVisualStyleBackColor = true;
            this.cmdSelectImage.Click += new System.EventHandler(this.cmdSelectImage_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "filter:";
            // 
            // txtFiler2
            // 
            this.txtFiler2.Location = new System.Drawing.Point(357, 219);
            this.txtFiler2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler2.Name = "txtFiler2";
            this.txtFiler2.Size = new System.Drawing.Size(185, 22);
            this.txtFiler2.TabIndex = 26;
            this.txtFiler2.Text = ".jpg|.jpeg";
            // 
            // txtFiler3
            // 
            this.txtFiler3.Location = new System.Drawing.Point(357, 340);
            this.txtFiler3.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiler3.Name = "txtFiler3";
            this.txtFiler3.Size = new System.Drawing.Size(185, 22);
            this.txtFiler3.TabIndex = 31;
            this.txtFiler3.Text = ".jpg|.jpeg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 320);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "filter:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(573, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 389);
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
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(30, 24);
            this.toolStripDropDownButton1.Text = "?";
            // 
            // ToolStripInfo
            // 
            this.ToolStripInfo.Name = "ToolStripInfo";
            this.ToolStripInfo.Size = new System.Drawing.Size(181, 26);
            this.ToolStripInfo.Text = "Info";
            this.ToolStripInfo.Click += new System.EventHandler(this.ToolStripInfo_Click);
            // 
            // frmPhotoSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1093, 569);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiler3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdSelectImage);
            this.Controls.Add(this.radKnownImage);
            this.Controls.Add(this.txtFiler2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddConstant_s);
            this.Controls.Add(this.txtAddConstant_min);
            this.Controls.Add(this.txtAddConstant_h);
            this.Controls.Add(this.txtAddConstant_D);
            this.Controls.Add(this.txtAddConstant_Mon);
            this.Controls.Add(this.txtAddConstant_Y);
            this.Controls.Add(this.radAddConstantTime);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cmdstart1);
            this.Controls.Add(this.cmdstart);
            this.Controls.Add(this.progBarTask);
            this.Controls.Add(this.txtFiler);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radSort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhotoSort";
            this.Text = "PhotoSort";
            this.Load += new System.EventHandler(this.frmFotoSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtFiler;
        private System.Windows.Forms.ProgressBar progBarTask;
        private System.Windows.Forms.Button cmdstart;
        private System.Windows.Forms.Button cmdstart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.RadioButton radAddConstantTime;
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
        private System.Windows.Forms.RadioButton radKnownImage;
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
    }
}