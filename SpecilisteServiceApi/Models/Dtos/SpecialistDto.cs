using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecilisteServiceApi.Models.Dtos
{
    public class SpecialistDto
    {
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Image { get; set; }
        public string Speciality { get; set; }
        public DateTime joined { get; set; }

        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }


    }
}
