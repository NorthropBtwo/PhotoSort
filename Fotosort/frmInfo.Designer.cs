namespace Fotosort
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.lblVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelProgressbar = new System.Windows.Forms.LinkLabel();
            this.linkLabelArt1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelArtwork2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(21, 23);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(138, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "photosort v0.01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright ® 2018, Northrop\'s Studios, MIT License";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(640, 119);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "special thanks to:";
            // 
            // linkLabelProgressbar
            // 
            this.linkLabelProgressbar.AutoSize = true;
            this.linkLabelProgressbar.Location = new System.Drawing.Point(21, 278);
            this.linkLabelProgressbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelProgressbar.Name = "linkLabelProgressbar";
            this.linkLabelProgressbar.Size = new System.Drawing.Size(342, 17);
            this.linkLabelProgressbar.TabIndex = 4;
            this.linkLabelProgressbar.TabStop = true;
            this.linkLabelProgressbar.Tag = "https://wyday.com/windows-7-progress-bar/";
            this.linkLabelProgressbar.Text = "wyday for windows 7 progressbar under BSD license ";
            this.linkLabelProgressbar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelArt1
            // 
            this.linkLabelArt1.AutoSize = true;
            this.linkLabelArt1.Location = new System.Drawing.Point(21, 308);
            this.linkLabelArt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelArt1.Name = "linkLabelArt1";
            this.linkLabelArt1.Size = new System.Drawing.Size(475, 17);
            this.linkLabelArt1.TabIndex = 5;
            this.linkLabelArt1.TabStop = true;
            this.linkLabelArt1.Tag = "https://www.iconfinder.com/icons/905641/ascending_az_filters_sort_sorting_icon";
            this.linkLabelArt1.Text = "Benjamin STAWARZ for arrow in icon under CC BY 3.0 (image is modified)";
            this.linkLabelArt1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelArtwork2
            // 
            this.linkLabelArtwork2.AutoSize = true;
            this.linkLabelArtwork2.Location = new System.Drawing.Point(21, 338);
            this.linkLabelArtwork2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelArtwork2.Name = "linkLabelArtwork2";
            this.linkLabelArtwork2.Size = new System.Drawing.Size(475, 17);
            this.linkLabelArtwork2.TabIndex = 6;
            this.linkLabelArtwork2.TabStop = true;
            this.linkLabelArtwork2.Tag = "https://www.iconfinder.com/icons/118887/generic_image_icon";
            this.linkLabelArtwork2.Text = "Tango for generic, image icon under CC BY-NC 3.0 NL (image is modified)";
            this.linkLabelArtwork2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 428);
            this.Controls.Add(this.linkLabelArtwork2);
            this.Controls.Add(this.linkLabelArt1);
            this.Controls.Add(this.linkLabelProgressbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfo";
            this.ShowInTaskbar = false;
            this.Text = "frmInfo";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelProgressbar;
        private System.Windows.Forms.LinkLabel linkLabelArt1;
        private System.Windows.Forms.LinkLabel linkLabelArtwork2;
    }
}