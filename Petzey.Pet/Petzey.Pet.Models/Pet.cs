using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        public PetParent Owner { get; set; }

        [MaxLength(30)]
        [Required]
        public string PetName { get; set; }

        [Required]
        public int PetAge { get; set; }
        public  DateTime DOB { get; set; }

        [MaxLength(10)]
        [Required]
        public string Gender { get; set; }

        [MaxLength(10)]
        [Required]
        public string BloodGroup { get; set; }

        [MaxLength(50)]
        [Required]
        public string Allergies { get; set; }

        [MaxLength(30)]
        [Required]
        public string PetType { get; set; }

        [MaxLength(30)]
        [Required]
        public string PetBreed { get; set; }
    }
}
