using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ATX_LINQ.Annotations;

namespace ATX_LINQ.Model
{
    public class StockModel : INotifyPropertyChanged
    {
        private IList<StockModel> StockList = new List<StockModel>();

        /*
        List<StockModel> students = new List<StockModel>() {};
        */

        public StockModel(String date, double open, double high, double low, double lastclose)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            LastClose = lastclose;
        }


        #region Property

        private String date ="";
        public String Date
        {
            get => date;
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }
        private double open = 0.0;
        public double Open
        {
            get => open;
            set
            {
                if (open != value)
                {
                    open = value;
                    OnPropertyChanged();
                }
            }
        }
        private double high = 0.0;
        public double High
        {
            get => high;
            set
            {
                if (high != value)
                {
                    high = value;
                    OnPropertyChanged();
                }
            }
        }
        private double low = 0.0;
        public double Low
        {
            get => low;
            set
            {
                if (low != value)
                {
                    low = value;
                    OnPropertyChanged();
                }
            }
        }
        private double lastclose = 0.0;
        public double LastClose
        {
            get => lastclose;
            set
            {
                if (lastclose != value)
                {
                    lastclose = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
