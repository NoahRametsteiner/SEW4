using System.Data.Entity;
using MyERP.Model;

namespace MyERP.Context
{
    class InvoiceContext: DbContext
    {
        public InvoiceContext()
        {
            Database.SetInitializer<InvoiceContext>(new InvoiceInitializer());
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
