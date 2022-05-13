using System;
using System.Windows.Media.Imaging;
using MyERP.Model;

namespace MyERP.Printing
{
    class InvoicePrintData
    {
        public DateTime PrintingDate => DateTime.Now;
        public Invoice Invoice { get; set; }
        public String Anschrift { get; set; } = "Schulzentrum Ybbs";
        public String Adresse { get; set; } = "Schulring 6, 3370 Ybbs/Donau";
        public BitmapSource BarCode { get; set; }
        public BitmapSource QrCode { get; set; }
    }
}
