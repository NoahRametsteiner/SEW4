using Newtonsoft.Json;

namespace MyERP.Model
{
    class Position
    {
        // Key 3. NF: Id von InvoiceEntity + ItemNr
        public int Id { get; set; } // Surrogate Key / Stellvertreter Key
        public int ItemNr { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public int InvoiceId { get; set; }             // FK der Rechung
        [JsonIgnore]
        public Invoice Invoice { get; set; }     // Referenz auf die Rechnung
    }
}
