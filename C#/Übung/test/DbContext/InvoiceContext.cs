using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Rechnungsverwaltung.DbContext
{
    class InvoiceContext : System.Data.Entity.DbContext
    {
        public DbSet<InvoiceContext> Rechnungen { get; set; }
    }
}
