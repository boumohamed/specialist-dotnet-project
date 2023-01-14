using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models.Dtos
{
    public class OfferRequestDto
    {
        public string titre { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        
    }
}
