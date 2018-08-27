using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fotosort
{
    public partial class frmPhotoSort : Form
    {
        public enum BackgroundWork
        {
            Sort,
            AddConstantTime,
            FromKnownImage,
            ScanCameras,
        }

        public frmPhotoSort()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        BackgroundWork backGroundWork;
        string cameraFilter;
        private string photoDirectory;

        List<string> camerasFound = new List<string>();

        string selectedFileName;
        DateTime selectedFileCaptureTime;

        private void frmFotoSort_Load(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            cobFilterCamera1.SelectedIndex = 0;
            cobFilterCamera2.SelectedIndex = 0;
            cobFilterCamera3.SelectedIndex = 0;

            foreach (Control control in this.Controls)
            {
                Type t = control.GetType();
                if (control.GetType() == typeof(GroupBox))
                {
                    foreach (Control subControl in control.Controls)
                    {
                        subControl.Font = control.Font;
                    }
                    control.Font = new Font("Arial", 9, FontStyle.Bold);
                }
                
            }

            setPhotoDirectory(Directory.GetCurrentDirectory());

            InitUpdate();
        }

        private void InitUpdate()
        {
            if( GithubSingleFileUpdater.IsUpToDate())
            {
                cmdUpdate.Visible = false;
            }

            if (File.Exists(oldVersion))
            {
                File.Delete(oldVersion);
            }
        }



        private void cmdstart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                this.UseWaitCursor = true;
                cmdStartSort.Enabled = false;
                cmdStartConstant.Enabled = false;
                cmdStartByKnown.Enabled = false;
                cmdCancel.Enabled = true;
                cmdCancel.Visible = true;

                backgroundWorker1.RunWorkerAsync();
            }
        }

        //ToDo: Worker thread should no access UI elements
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(0);

            if (backGroundWork == BackgroundWork.Sort)
            {
                List<PhotoInfo> photoInfos = PhotoSortMgr.GetPhotosFromDirectory(photoDirectory, txtFiler.Text, cameraFilter, sender as BackgroundWorker, e);
                photoInfos.Sort();
                PhotoSortMgr.Rename(photoInfos, txtPrefix.Text, txtStartIndex.Text, sender as BackgroundWorker, e);
            }
            else if (backGroundWork == BackgroundWork.AddConstantTime)
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

                PhotoSortMgr.ChangeCaptureDate(photoDirectory, lts, txtFiler2.Text, cameraFilter, sender as BackgroundWorker, e);
            }
            else if (backGroundWork == BackgroundWork.FromKnownImage)
            {
                TimeSpan difference = dateTimePicker1.Value.Subtract(selectedFileCaptureTime);
                PhotoSortMgr.LongTimeSpan lts = PhotoSortMgr.LongTimeSpan.FromTimeSpan(difference);

                PhotoSortMgr.ChangeCaptureDate(photoDirectory, lts, txtFiler3.Text, cameraFilter, sender as BackgroundWorker, e);
            }
            else if (backGroundWork == BackgroundWork.ScanCameras)
            {
                camerasFound = PhotoSortMgr.GetListOfCamersFromDirectory(photoDirectory, txtFiler.Text + "|" + txtFiler2.Text + "|" + txtFiler3.Text, sender as BackgroundWorker, e);
            }

            backgroundWorker1.ReportProgress(100);
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            windows7ProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UseWaitCursor = false;
            Cursor.Position = Cursor.Position; //C# needs this line to correctly update teh WaitCursor
            cmdStartSort.Enabled = true;
            cmdStartConstant.Enabled = true;
            cmdStartByKnown.Enabled = true;
            cmdCancel.Enabled = false;
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

            if (backGroundWork == BackgroundWork.ScanCameras)
            {
                cobFilterCamera1.Enabled = true;
                cobFilterCamera1.Items.Clear();
                cobFilterCamera1.Items.Add("all");
                cobFilterCamera1.Items.AddRange(camerasFound.ToArray());
                cobFilterCamera1.SelectedIndex = 0;

                cobFilterCamera2.Enabled = true;
                cobFilterCamera2.Items.Clear();
                cobFilterCamera2.Items.Add("all");
                cobFilterCamera2.Items.AddRange(camerasFound.ToArray());
                cobFilterCamera2.SelectedIndex = 0;

                cobFilterCamera3.Enabled = true;
                cobFilterCamera3.Items.Clear();
                cobFilterCamera3.Items.Add("all");
                cobFilterCamera3.Items.AddRange(camerasFound.ToArray());
                cobFilterCamera3.SelectedIndex = 0;
            }
            else if (backGroundWork == BackgroundWork.FromKnownImage)
            {
                selectImage(); //reload the selected image
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void selectImage()
        {
            DateTime captureTime = DateTime.MinValue;

            try
            {
                Image img = PhotoSortMgr.GetImageFromFile(selectedFileName, ref captureTime);
                if (captureTime != DateTime.MinValue)
                {
                    DisplayImage(img);
                }
                else
                {
                    img.Dispose();
                }

                selectedFileCaptureTime = captureTime;
                dateTimePicker1.Value = captureTime;
            }
            catch (Exception ex)
            {
                selectedFileName = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSelectImage_Click(object sender, EventArgs e)
        {
            DialogResult result =  openFileDialog1.ShowDialog();
            

            if (result == DialogResult.OK) // Test result.
            {
                selectedFileName = openFileDialog1.FileName;

                selectImage();
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

        string newestVersion = Process.GetCurrentProcess().MainModule.FileName + ".temp";
        string oldVersion = Process.GetCurrentProcess().MainModule.FileName + ".oldtemp";
        string curVersion = Process.GetCurrentProcess().MainModule.FileName;

        private void cmdUpdate_Click(object sender, EventArgs e)
        {   
            GithubSingleFileUpdater.DownloadReleaseVersion(newestVersion);
            File.Move(curVersion, oldVersion);
            File.Move(newestVersion, curVersion);

            if (File.Exists(curVersion))
            {
                Process.Start(curVersion);
            }

            Environment.Exit(0);
        }

        private void cmdSelCam1_Click(object sender, EventArgs e)
        {
            backGroundWork = BackgroundWork.ScanCameras;
            cmdstart_Click(sender, e);
        }

        private void cmdStartSort_Click(object sender, EventArgs e)
        {
            backGroundWork = BackgroundWork.Sort;
            cameraFilter = getCamerFilter(cobFilterCamera1);
            cmdstart_Click(sender, e);
        }

        private void cmdStartConstant_Click(object sender, EventArgs e)
        {
            backGroundWork = BackgroundWork.AddConstantTime;
            cameraFilter = getCamerFilter(cobFilterCamera2);
            cmdstart_Click(sender, e);
        }

        private void cmdStartByKnown_Click(object sender, EventArgs e)
        {
            backGroundWork = BackgroundWork.FromKnownImage;
            cameraFilter = getCamerFilter(cobFilterCamera3);
            cmdstart_Click(sender, e);
        }

        private string getCamerFilter(ComboBox cob)
        {
            if(cob.SelectedItem.ToString() == "all")
            {
                return null;
            }
            else
            {
                return cob.SelectedItem.ToString();
            }
        }

        private void toolStripInstruction_Click(object sender, EventArgs e)
        {
            frmInstruction instruction = new frmInstruction();
            instruction.ShowDialog();
        }


        
        private void setPhotoDirectory(string newDir)
        {
            photoDirectory = newDir;
            toolStripLblPhotoDir.Text = newDir;
            folderBrowserDialog1.SelectedPath = newDir;
        }

        private void toolStripChangeDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                setPhotoDirectory(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
