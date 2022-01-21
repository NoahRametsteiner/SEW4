using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungsverwaltung.ViewModel
{
    class RechnungViewModel : INotifyPropertyChanged
    {

        #region Prop

        #region Id

        private int Id = 0;
        public int id
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region CustomerName

        private string CustomerName = "";
        public String customername
        {
            get => customername;
            set
            {
                if (customername != value)
                {
                    customername = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region CustomerAddress

        private string CustomerAddress = "";
        public String customeraddress
        {
            get => customeraddress;
            set
            {
                if (customeraddress != value)
                {
                    customeraddress = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region Amount

        private double Amount = 0;
        public double amount
        {
            get => amount;
            set
            {
                if (amount != value)
                {
                    amount = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region InvoiceDate

        private DateTime InvoiceDate;
        public DateTime invoicedate
        {
            get => invoicedate;
            set
            {
                if (invoicedate != value)
                {
                    invoicedate = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region InvoiceDate

        private int Vat;
        public int vat
        {
            get => vat;
            set
            {
                if (vat != value)
                {
                    vat = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #endregion

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

