using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungsverwaltung.ViewModel
{
    class ViewModel
    {
        private int Id { get; set; }
        private string CustomerName { get; set; }
        private string CustomerAddress { get; set; }
        private double Amount { get; set; }
        private DateTime InvoiceDate { get; set; }
        private int Vat { get; set; }
    }
}
