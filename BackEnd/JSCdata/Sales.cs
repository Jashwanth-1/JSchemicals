using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSCdata
{
    public class Sales
    {
        public required string InvoiceNumber { get; set; }
        public required string InvoiceDate { get; set; }
        public required string PurchaseOrder { get; set; }
        public required string PurchaseOrderDate { get; set; }
        public required string CustomerId { get; set; }
        public required float Amount { get; set;}
        public string? PaymentDate { get; set;}
    }
}
