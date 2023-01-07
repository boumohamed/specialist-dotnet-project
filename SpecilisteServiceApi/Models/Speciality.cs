using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SpecilisteServiceApi.Models
{
    public class Speciality
    {
        [Key]
        private string id;
        [Required]
        private string name;
    }
}
