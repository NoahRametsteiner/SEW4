using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Rechnungsverwaltung.Model;

namespace Rechnungsverwaltung.ViewModel
{
    class RechnungenViewModel : INotifyPropertyChanged
    {

        private InvoiceList list;

        public InvoiceList List
        {
            get => list;
            set
            {
                list = value;
                RaisePropertyChanged();
            }
        }

        public Invoice CurrentInvoice { get; set; }
        public List<Invoice> lists = new List<Invoice>();
        public string ChosenName { get; set; }
        public string ChosenAdress { get; set; }
        public DateTime ChosenDate { get; set; } = DateTime.Now;
        public double ChosenAmount { get; set; }
        public int ChosenVat { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public RechnungenViewModel()
        {
            


            var ctx = new InvoiceContext();
            lists = ctx.Rechnungen.ToList();
            List = InvoiceList.ConvertFromList(lists);

            AddCommand = new RelayCommand(e =>
            {

                Invoice invoice = new Invoice()
                {
                    CustomerName = ChosenName,
                    InvoiceDate = ChosenDate,
                    Amount = ChosenAmount,
                    Vat = ChosenVat,
                    CustomerAdress = ChosenAdress
                };

                try
                {
                    using (ctx = new InvoiceContext())
                    {
                        ctx.Rechnungen.Add(invoice); //Datensatz einfügen
                        ctx.SaveChanges();  //Speichern / commit

                     
                        lists = ctx.Rechnungen.ToList();
                        List = InvoiceList.ConvertFromList(lists);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            );

           
            DeleteCommand = new RelayCommand(e =>
            {
                
               
                DialogResult dialog = MessageBox.Show("Endgültig Löschen?", "", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    try
                    {
                        using (ctx = new InvoiceContext())
                        {
                            var user = ctx.Rechnungen.Find(CurrentInvoice.ID);
                            if (user != null)
                            {
                                ctx.Rechnungen.Remove(user);
                                ctx.SaveChanges();
                                lists = ctx.Rechnungen.ToList();
                                List = InvoiceList.ConvertFromList(lists);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            );

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
