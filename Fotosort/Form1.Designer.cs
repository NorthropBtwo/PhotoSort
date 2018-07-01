namespace Fotosort
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
            this.cmdstart = new System.Windows.Forms.Button();
            this.lisDate = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotFiles = new System.Windows.Forms.TextBox();
            this.textBoxActImg = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cmdstart
            // 
            this.cmdstart.Location = new System.Drawing.Point(837, 478);
            this.cmdstart.Margin = new System.Windows.Forms.Padding(4);
            this.cmdstart.Name = "cmdstart";
            this.cmdstart.Size = new System.Drawing.Size(221, 42);
            this.cmdstart.TabIndex = 0;
            this.cmdstart.Text = "start";
            this.cmdstart.UseVisualStyleBackColor = true;
            this.cmdstart.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // lisDate
            // 
            this.lisDate.Location = new System.Drawing.Point(16, 28);
            this.lisDate.Margin = new System.Windows.Forms.Padding(4);
            this.lisDate.Multiline = true;
            this.lisDate.Name = "lisDate";
            this.lisDate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lisDate.Size = new System.Drawing.Size(504, 490);
            this.lisDate.TabIndex = 1;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(796, 375);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(261, 22);
            this.txtPrefix.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numbre of Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actual File";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTotFiles
            // 
            this.textBoxTotFiles.Location = new System.Drawing.Point(837, 416);
            this.textBoxTotFiles.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotFiles.Name = "textBoxTotFiles";
            this.textBoxTotFiles.ReadOnly = true;
            this.textBoxTotFiles.Size = new System.Drawing.Size(220, 22);
            this.textBoxTotFiles.TabIndex = 6;
            // 
            // textBoxActImg
            // 
            this.textBoxActImg.Location = new System.Drawing.Point(837, 446);
            this.textBoxActImg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxActImg.Name = "textBoxActImg";
            this.textBoxActImg.ReadOnly = true;
            this.textBoxActImg.Size = new System.Drawing.Size(220, 22);
            this.textBoxActImg.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 527);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(1043, 28);
            this.progressBar1.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 569);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxActImg);
            this.Controls.Add(this.textBoxTotFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lisDate);
            this.Controls.Add(this.cmdstart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fotosort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdstart;
        private System.Windows.Forms.TextBox lisDate;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotFiles;
        private System.Windows.Forms.TextBox textBoxActImg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

