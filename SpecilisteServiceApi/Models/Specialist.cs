using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecilisteServiceApi.Models
{
    public class Specialist
    {
        [Key]
        public string id { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string  Tel { get; set; }

        [Required]
        public DateTime joined { get; set; }

        public string Image { get; set; }

        [Required]
        public string Speciality { get; set; }


        public string street { get; set; }

        [Required]
        public string city { get; set; }

        public string zipCode { get; set; }
    }
}
