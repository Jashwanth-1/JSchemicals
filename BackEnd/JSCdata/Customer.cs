using System.ComponentModel.DataAnnotations;

namespace JSCdata
{
    public class Customer
    {
        [Key]
        public required string CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public required string GSTIN {  get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
