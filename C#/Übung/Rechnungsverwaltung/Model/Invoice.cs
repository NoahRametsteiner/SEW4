using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungsverwaltung.Model
{
    class Invoice : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string customername { get; set; }
        public string customeraddress { get; set; }
        public double amount { get; set; }
        public DateTime invoicedate { get; set; }
        public int vat { get; set; }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
