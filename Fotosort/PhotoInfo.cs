using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fotosort
{
    public class PhotoInfo : IComparable
    {

        private FileInfo fileInfo;
        private string captureDate;

        public PhotoInfo(FileInfo fileInfo, string captureDate)
        {
            this.fileInfo = fileInfo;
            this.captureDate = captureDate;
        }


        public string CaptureDate { get { return captureDate; } }

        public string Extension { get { return fileInfo.Extension; } }

        public string FullName { get { return fileInfo.FullName; } }

        public string DirectoryName { get { return fileInfo.DirectoryName; } }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            PhotoInfo otherFotoInfo = obj as PhotoInfo;
            if (otherFotoInfo != null)
                return this.CaptureDate.CompareTo(otherFotoInfo.CaptureDate);
            else
                throw new ArgumentException("Object is not a PhotoInfo");
        }

    }
}
