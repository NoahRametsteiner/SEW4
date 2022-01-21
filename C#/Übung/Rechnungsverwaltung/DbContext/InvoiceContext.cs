using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungsverwaltung.DbContext
{
    class InvoiceContext : System.Data.Entity.DbContext
    {
        public DbSet<InvoiceContext> Rechnungen { get; set; }
    }
}
