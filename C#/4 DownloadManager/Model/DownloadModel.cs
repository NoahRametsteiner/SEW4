using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DownloadManager.Model
{
    class DownloadModel : INotifyPropertyChanged
    {
        #region Attribute
        private string url = string.Empty;
        private string html = string.Empty;
        private int time = 0;
        #endregion

        #region Properties

        public string Url
        {
            get => url;
            set
            {
                url = value;
                OnPropertyChanged();
            }
        }

        public string Html
        {
            get => html;
            set
            {
                html = value;
                OnPropertyChanged();
            }
        }

        public int Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Commands

        public ICommand StratDownloadCommand { get; set; }
        public ICommand ExitDownloadCommand { get; private set; }

        #endregion
    }
}
