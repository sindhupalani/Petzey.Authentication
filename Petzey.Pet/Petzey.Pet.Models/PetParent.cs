using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Models
{
    public class PetParent
    {
        [Key]
        public int ParentId { get; set; }
        public Pet Pet { get; set; }

        [MaxLength(30)]
        [Required]
        public string ParentName { get; set; }

        [MaxLength(15)]
        [Required]
        public string PhoneNum { get; set; }

        [MaxLength(100)]
       
        public string Address { get; set; }

        [MaxLength(30)]
        [Required]
        public string EmailId { get; set; }

    }
}
