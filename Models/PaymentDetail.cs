using System.ComponentModel.DataAnnotations;

namespace test_mvc_webapp.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PMId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
    }
}