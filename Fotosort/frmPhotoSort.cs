using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fotosort
{
    public partial class frmPhotoSort : Form
    {
        public frmPhotoSort()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        List<TextBox> sortTextParameters;
        List<TextBox> addConstantTimeTextParameters;

        string selectedFileName;
        DateTime selectedFileCaptureTime;

        private void frmFotoSort_Load(object sender, EventArgs e)
        {
            sortTextParameters = new List<TextBox>() { txtPrefix, txtStartIndex, txtFiler };
            addConstantTimeTextParameters = new List<TextBox>() { txtAddConstant_Y, txtAddConstant_Mon, txtAddConstant_D, txtAddConstant_h, txtAddConstant_min, txtAddConstant_s ,txtFiler2};

            foreach (var txtBox in sortTextParameters)
            {
                txtBox.TextChanged += SetSortActive;
            }
            foreach (var txtBox in addConstantTimeTextParameters)
            {
                txtBox.TextChanged += SetAddConstantTimeActive;
            }


            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            radSort.Checked = true;
        }

        private void SetSortActive(object sender, EventArgs e)
        {
            radSort.Checked = true;
        }

        private void SetAddConstantTimeActive(object sender, EventArgs e)
        {
            radAddConstantTime.Checked = true;
        }


        private void cmdstart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                this.UseWaitCursor = true;
                cmdstart.Enabled = false;
                cmdstart1.Enabled = false;
                cancel.Enabled = true;
                cancel1.Enabled = true;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        //ToDo: Worker thread should no access UI elements
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(0);

            if (radSort.Checked)
            {
                List<PhotoInfo> photoInfos = PhotoSortMgr.GetPhotosFromDirectory(Directory.GetCurrentDirectory(), txtFiler.Text, sender as BackgroundWorker, e);
                photoInfos.Sort();
                PhotoSortMgr.Rename(photoInfos, txtPrefix.Text, txtStartIndex.Text, sender as BackgroundWorker, e);
            }
            else if (radAddConstantTime.Checked)
            {
                PhotoSortMgr.LongTimeSpan lts;

                try
                {
                    lts = PhotoSortMgr.LongTimeSpan.FromStrings(txtAddConstant_Y.Text, txtAddConstant_Mon.Text, txtAddConstant_D.Text, txtAddConstant_h.Text, txtAddConstant_min.Text, txtAddConstant_s.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("error: can not convert the given time span!!!");
                    return;
                }

                PhotoSortMgr.ChangeCaptureDate(Directory.GetCurrentDirectory(), lts, txtFiler2.Text, sender as BackgroundWorker, e);
            }
            else if (radKnownImage.Checked)
            {
                TimeSpan difference =  dateTimePicker1.Value.Subtract(selectedFileCaptureTime);
                PhotoSortMgr.LongTimeSpan lts = PhotoSortMgr.LongTimeSpan.FromTimeSpan(difference);
                selectedFileCaptureTime = dateTimePicker1.Value;

                PhotoSortMgr.ChangeCaptureDate(Directory.GetCurrentDirectory(), lts, txtFiler3.Text, sender as BackgroundWorker, e);
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            windows7ProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UseWaitCursor = false;
            cmdstart.Enabled = true;
            cmdstart1.Enabled = true;
            cancel.Enabled = false;
            cancel1.Enabled = false;
            /*
            if (e.Cancelled == true)
            {
                labelResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                labelResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                labelResult.Text = "Done!";
            }*/
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void cmdSelectImage_Click(object sender, EventArgs e)
        {
            DialogResult result =  openFileDialog1.ShowDialog();
            DateTime captureTime = DateTime.MinValue;

            if (result == DialogResult.OK) // Test result.
            {
                selectedFileName = openFileDialog1.FileName;

                try
                {
                    Image img = PhotoSortMgr.GetImageFromFile(selectedFileName,ref captureTime);
                    if(captureTime != DateTime.MinValue)
                    {
                        DisplayImage(img);
                    }
                    else
                    {
                        img.Dispose();
                    }

                    selectedFileCaptureTime = captureTime;
                    dateTimePicker1.Value = captureTime;
                    radKnownImage.Checked = true;
                }
                catch (Exception ex)
                {
                    selectedFileName = "";
                    MessageBox.Show(ex.Message);
                }
            }

        }


        Image currentlyDisplayed;

        private void DisplayImage(Image newImage)
        {
            try
            {
                if (newImage == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = newImage;
                }

                if(currentlyDisplayed != null)
                    currentlyDisplayed.Dispose();
                currentlyDisplayed = newImage;
            }
            catch (Exception ex)
            {
                if (currentlyDisplayed != null)
                    currentlyDisplayed.Dispose();
                currentlyDisplayed = null;
                throw ex;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripInfo_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.ShowDialog();
        }
    }
}
