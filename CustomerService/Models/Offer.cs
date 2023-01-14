using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CustomerService.Models
{
    public class Offer
    {
        [Key]
        public string offerId { get; set; }
        [Required, StringLength(50)]
        public string titre { get; set; }

        [Required, StringLength(50)]
        public string city { get; set; }

        public string description { get; set; }

        [Required]
        public DateTime created { get; set; }

        public string customerId { get; set; }
        public Customer customer { get; set; }
    }
}
