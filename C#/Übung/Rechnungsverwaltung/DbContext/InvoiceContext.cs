using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rechnungsverwaltung.Model;

namespace Rechnungsverwaltung.DbContext
{
    class InvoiceContext : System.Data.Entity.DbContext
    {
        public DbSet<Invoice> Rechnungen { get; set; }
    }
}
