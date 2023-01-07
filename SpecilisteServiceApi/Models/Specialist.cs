using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecilisteServiceApi.Models
{
    public class Specialist
    {
        [Key]
        public string SpecialistID { get; set; }
        [Required, StringLength(50)]
        public string SpecialistName { get; set; }
        [Required]
        public string SpecialistEmail { get; set; }

        public string  SpecialistTel { get; set; }

        public string Image { get; set; }
    }
}
