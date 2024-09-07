using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSCdata
{
    public class Order
    {
        
        public required string InvoiceNumber { get; set; }
        public required string ProductId { get; set; }
        public required int Quantiy {  get; set; }
        public required float Price { get; set; }
        public required float GST { get; set; }
        public required float Total  { get; set;}
    }
}
