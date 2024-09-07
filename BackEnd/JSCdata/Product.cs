using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSCdata
{
    public class Product
    {
        [Key]
        public required string ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string HSNCode { get; set; }
    }
}
