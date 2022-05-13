using System;
using System.Collections.Generic;

namespace MyERP.Model
{
    class Invoice
    {   
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public double Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Vat { get; set; }

        public ICollection<Position> Positions { get; set; } = new List<Position>();
    }
}
