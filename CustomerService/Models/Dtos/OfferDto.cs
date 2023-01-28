using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models.Dtos
{
    public class OfferDto
    {
        public string offerId { get; set; }
        public string titre { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        public DateTime created { get; set; }
        public string speciality { get; set; }
        public string customerId { get; set; }
        public Customer customer{ get; set; }
        public DateTime delay { get; set; }
        public string experience { get; set; }
        public bool diploma { get; set; }
        public string type { get; set; }
        public string budget { get; set; }
    }
}
