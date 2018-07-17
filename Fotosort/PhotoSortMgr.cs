using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fotosort
{
    public class PhotoSortMgr
    {

        public struct LongTimeSpan
        {
            int Years;
            int Months;
            int Days;
            int Hours;
            int Minutes;
            int Seconds;

            public static LongTimeSpan FromStrings(string years, string months, string days, string hours, string minutes, string seconds)
            {
                LongTimeSpan lts;

                lts.Years = int.Parse(years);
                lts.Months = int.Parse(months);
                lts.Days = int.Parse(days);
                lts.Hours = int.Parse(hours);
                lts.Minutes = int.Parse(minutes);
                lts.Seconds = int.Parse(seconds);

                return lts;
            }

            public static LongTimeSpan FromTimeSpan(TimeSpan timeSpan)
            {
                LongTimeSpan lts;

                lts.Years = 0;
                lts.Months = 0;
                lts.Days = timeSpan.Days;
                lts.Hours = timeSpan.Hours;
                lts.Minutes = timeSpan.Minutes;
                lts.Seconds = timeSpan.Seconds;

                return lts;
            }

            public DateTime IncreaseDateTime(DateTime datetime)
            {
                datetime = datetime.AddYears(this.Years);
                datetime = datetime.AddMonths(this.Months);
                datetime = datetime.AddDays(this.Days);
                datetime = datetime.AddHours(this.Hours);
                datetime = datetime.AddMinutes(this.Minutes);
                datetime = datetime.AddSeconds(this.Seconds);
                return datetime;
            }
        }

        public struct ImageHeaderInfo
        {
            public string captureDate;
            public string manufacturer;
            public string model;
        }


            public static List<PhotoInfo> GetPhotosFromDirectory(string directory, string filter = ".jpg|.jpeg", BackgroundWorker worker = null, DoWorkEventArgs e = null)
        {
            List<PhotoInfo> photos = new List<PhotoInfo>();

            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            FileInfo[] fileInfos = dirInfo.GetFiles();

            int progress = 0;

            foreach (var fileInfo in fileInfos)
            {
                if(ApplyFilter(fileInfo.Name, filter))
                {
                    string capDate = GetCaptureDate(fileInfo.FullName);
                    if(capDate != "")
                    {
                        photos.Add(new PhotoInfo(fileInfo, capDate));
                    }
                }

                progress++;

                if (worker != null)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return new List<PhotoInfo>();
                    }
                    else
                    {
                        worker.ReportProgress(50 * progress / fileInfos.Length);
                    }
                }
            }


            return photos;
        }

        public static bool ApplyFilter(string fileName, string filter)
        {
            foreach (var ending in filter.Split('|'))
            {
                if (fileName.ToLower().EndsWith(ending))
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetCaptureDate(string fullFilename)
        {

            ImageHeaderInfo headerInfo = GetHeaderInfo(fullFilename);
            return headerInfo.captureDate;
        }

        public static ImageHeaderInfo GetHeaderInfo(string fullFilename)
        {

            ImageHeaderInfo headerInfo = new ImageHeaderInfo();
            Encoding enc = Encoding.Default;

            using (Image img = Image.FromFile(fullFilename))
            {
                foreach (PropertyItem Info in img.PropertyItems)
                {
                    switch (Info.Id.ToString("X"))
                    {
                        case "9003":
                            headerInfo.captureDate = enc.GetString(Info.Value, 0, Info.Len - 1);
                            break;
                        case "10F":
                            headerInfo.manufacturer = enc.GetString(Info.Value, 0, Info.Len - 1);
                            break;
                        case "110":
                            headerInfo.model = enc.GetString(Info.Value, 0, Info.Len - 1);
                            break;
                    }
                }
            }

            return headerInfo;
        }

        public static string ChangeCaptureDate(string fullFilename, LongTimeSpan timeDiff)
        {
            string capDate = "";
            Encoding enc = Encoding.Default;
            DateTime datetime;


            Byte[] bytes = File.ReadAllBytes(fullFilename);
            using (MemoryStream stream = new MemoryStream(bytes))
            using (Image img = Image.FromStream(stream))
            {
                foreach (PropertyItem Info in img.PropertyItems)
                {
                    switch (Info.Id.ToString("X"))
                    {
                        case "110":
                            break;
                        case "9003":
                            capDate = enc.GetString(Info.Value, 0, Info.Len - 1);
                            datetime = DateTime.ParseExact(capDate, "yyyy:MM:dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            datetime = timeDiff.IncreaseDateTime(datetime);

                            List<byte> zero = new List<byte>(new byte[] { 0 });
                            byte[] newValue = enc.GetBytes(datetime.ToString("yyyy:MM:dd HH:mm:ss")).Concat(zero).ToArray();
                            Info.Value = newValue;
                            Info.Len = newValue.Length;
                            img.SetPropertyItem(Info);
                            break;
                    }
                }

                img.Save(fullFilename);

            }

            return capDate;
        }



        public static void Rename(List<PhotoInfo> photos, string prefix, string startFormat, BackgroundWorker worker = null, DoWorkEventArgs e = null)
        {
            try
            {
                string format = string.Concat(Enumerable.Repeat("0", startFormat.Length));
                int index = 0, progress = 0;
                Int32.TryParse(startFormat, out index);

                foreach (var photo in photos)
                {
                    string newFile = photo.DirectoryName + "\\" + prefix + index.ToString(format) + photo.Extension;
                    File.Move(photo.FullName, newFile);
                    

                    index++;
                    progress++;

                    if (worker != null)
                    {
                        if(worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }
                        else
                        {
                            worker.ReportProgress(50 + 50 * progress / photos.Count);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
       
        }


        public static void ChangeCaptureDate(string directory, LongTimeSpan timeDiff, string filter = ".jpg|.jpeg", BackgroundWorker worker = null, DoWorkEventArgs e = null)
        {

            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            FileInfo[] fileInfos = dirInfo.GetFiles();

            int progress = 0;

            foreach (var fileInfo in fileInfos)
            {
                if (ApplyFilter(fileInfo.Name, filter))
                {
                    ChangeCaptureDate(fileInfo.FullName, timeDiff);
                }

                progress++;

                if (worker != null)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        worker.ReportProgress(100 * progress / fileInfos.Length);
                    }
                }
            }


            return;
        }



        public static Image GetImageFromFile(string fullFilename, ref DateTime captureTime)
        {
            string capDate = "";
            Encoding enc = Encoding.Default;
            Image img;

            Byte[] bytes = File.ReadAllBytes(fullFilename);
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                img = Image.FromStream(stream);
                foreach (PropertyItem Info in img.PropertyItems)
                {
                    switch (Info.Id.ToString("X"))
                    {
                        case "110":
                            break;
                        case "9003":
                            capDate = enc.GetString(Info.Value, 0, Info.Len - 1);
                            captureTime = DateTime.ParseExact(capDate, "yyyy:MM:dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            break;
                    }
                }

                img.Save(fullFilename);

            }

            return img;
        }


    }
}
