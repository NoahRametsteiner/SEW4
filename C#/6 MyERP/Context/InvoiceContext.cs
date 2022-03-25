using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Media.Imaging;
using MyERP.Model;

namespace MyERP.Context
{
    class InvoiceContext: DbContext
    {

        public InvoiceContext()
        {
            Database.SetInitializer(new InvoiceInitializer());
        }

        public BitmapSource QrCode { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }

    }
}
