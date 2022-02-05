using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rechnungsverwaltung.DbContext;
using Rechnungsverwaltung.Model;

namespace Rechnungsverwaltung.View
{
    /// <summary>
    /// Interaktionslogik für View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
        }

        private static void addRechnung(String cn, String ca, double am, DateTime id, int va)
        {
            Invoice newrechnung = new Invoice()
            {
                customername = cn,
                customeraddress = ca,
                amount = am,
                invoicedate = id,
                vat = va
            };
            try
            {
                using (var ctx = new InvoiceContext()) //Searches User By Primary Key
                {
                    ctx.Rechnungen.Add(newrechnung);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void findRechnugn(int id)
        {
            try
            {
                using (var ctx = new InvoiceContext())
                {
                    var user = ctx.Rechnungen.Find(id);

                    if (user != null)
                    {
                        Console.WriteLine("found " + user.id + " " + user.invoicedate);
                    }
                    else
                    {
                        Console.WriteLine("user not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*private static int findRechnungID()
        {
            int ident = 0;
            for (ident = 0;; ident++)
            {
                try
                {
                    using (var ctx = new InvoiceContext())
                    {
                        var user = ctx.Rechnungen.Find(ident);

                        if (user == null)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return (ident);
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            addRechnung(getCN.Text,getCA.Text,Convert.ToDouble(getAM.Text), Convert.ToDateTime(getID.Text), Convert.ToInt32(getVA.Text));
            findRechnugn(1);
        }
    }
}
