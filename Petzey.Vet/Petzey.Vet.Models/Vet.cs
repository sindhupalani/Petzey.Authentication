using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Vet.Models
{
    public class Vet
    {
        [Key]
        public int NPINum { get; set; }
        [MaxLength(30)]
        public string VetName { get; set; }
        [MaxLength(15)]
        public string PhoneNum { get; set; }
        [MaxLength(30)]
        public string EmailId { get; set; }
        [MaxLength(30)]
        public string Speciality { get; set; }
        [MaxLength(100)]
        public  string ClinicAddress { get; set; }
    }
}
