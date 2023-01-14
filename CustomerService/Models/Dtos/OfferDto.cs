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
        public string customerId { get; set; }
    }
}
