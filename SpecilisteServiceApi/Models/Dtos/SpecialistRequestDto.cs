using System.ComponentModel.DataAnnotations;

namespace SpecilisteServiceApi.Models.Dtos
{
    public class SpecialistRequestDto
    {
        public string SpecialistName { get; set; }
        public string SpecialistEmail { get; set; }
        public string SpecialistTel { get; set; }
        public string Image { get; set; }
    }
}
