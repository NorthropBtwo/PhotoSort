using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Fotosort
{
    public class GithubSingleFileUpdater
    {

        public struct Release
        {
            public string version;
            public string downloadUrl;
        }


        const string wwwLatestRelease = "https://api.github.com/repos/NorthropBtwo/PhotoSort/releases/latest";
        public const string CurrentVersion = "v0.0.3-beta";

        public static bool IsUpToDate()
        {
            try
            {
                return getLatestReleaseVersion().version == CurrentVersion;
            }
            catch (Exception) //for example no internet
            {
                return true; //can not download update
            }
          
        }

        public static Release getLatestReleaseVersion()
        {
            Release latestRelease = new Release();
            byte[] raw;
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                raw = wc.DownloadData(wwwLatestRelease);
            }
            string webData = System.Text.Encoding.UTF8.GetString(raw);


            string searchStr = "tag_name";
            int idxTagName = webData.IndexOf(searchStr);
            if (idxTagName == -1)
            {
                MessageBox.Show("getCurrenVersion: could not found ");
                return latestRelease;
            }
            int closed = webData.IndexOf('"', idxTagName + 1);
            int start = webData.IndexOf('"', closed + 1) + 1;
            int end = webData.IndexOf('"', start + 1);
            latestRelease.version = webData.Substring(start, end - start);

            searchStr = "browser_download_url";
            idxTagName = webData.IndexOf(searchStr);
            if (idxTagName == -1)
            {
                MessageBox.Show("getCurrenVersion: could not found ");
                return latestRelease;
            }
            closed = webData.IndexOf('"', idxTagName + 1);
            start = webData.IndexOf('"', closed + 1) + 1;
            end = webData.IndexOf('"', start + 1);
            latestRelease.downloadUrl = webData.Substring(start, end - start);


            return latestRelease;
        }


        public static string DownloadReleaseVersion(string fileName)
        {

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                wc.DownloadFile(getLatestReleaseVersion().downloadUrl, fileName);
            }

            return "";
        }
    }
}
