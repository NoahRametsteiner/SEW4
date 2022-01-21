using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungsverwaltung.Model
{
    class Invoice
    {
        public int id { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public double amount { get; set; }
        public DateTime invoicedate { get; set; }
        public int vat { get; set; }
    }
}
