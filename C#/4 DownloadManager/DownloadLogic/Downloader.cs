using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadManager.Model;
using System.Net;

namespace DownloadManager.DownloadLogic
{
    class Downloader
    {
        // Im ViewModel Im Command Setzen
        public DownloadModel DownloadModel { get; set; } = new DownloadModel();

        public static int NumberOfActiveDownloaders { get; private set; } = 0;
        private static object LockNumberOfActiveDownloaders = new object();
            
        public void Run()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            lock (LockNumberOfActiveDownloaders) {NumberOfActiveDownloaders++;}

            WebClient client = new WebClient();
            DownloadModel.Html = client.DownloadString(DownloadModel.Url);

            lock (LockNumberOfActiveDownloaders) { NumberOfActiveDownloaders--; }

            watch.Stop();
            DownloadModel.Time = (int) watch.ElapsedMilliseconds;
        }
    }
}
