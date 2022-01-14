using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DownloadManager.Model;

namespace DownloadManager.ViewModel
{
    class DownloadViewModel
    {
        public DownloadModel DownloadModel1 { get; } = new DownloadModel();
        public DownloadModel DownloadModel2 { get; } = new DownloadModel();
        public DownloadModel DownloadModel3 { get; } = new DownloadModel();

        private Thread downloadThread1;
        private Thread downloadThread2;

        private Task downloadTask1;


    }
}
