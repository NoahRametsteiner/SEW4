using System;
using MyERP.Context;
using MyERP.Model;

namespace MyERP.Logic
{
    class InvoiceLogic
    {
        public static void AddInvoice(Invoice invoice)
        {
            invoice.InvoiceDate = DateTime.Now;
            try
            {
                using (var ctx = new InvoiceContext())
                {
                    ctx.Invoices.Add(invoice);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void RemoveInvoice(Invoice invoice)
        {
            try
            {
                using (var ctx = new InvoiceContext())
                {
                    var found = ctx.Invoices.Find(invoice.Id);

                    if (found != null)
                    {
                        ctx.Invoices.Remove(found);
                        ctx.SaveChanges();
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
