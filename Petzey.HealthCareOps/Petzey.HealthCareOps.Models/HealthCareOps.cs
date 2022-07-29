using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.HealthCareOps.Models
{
    public class HealthCareOps
    {
        [Key]
        public int OpsId { get; set; }
        [MaxLength(30)]
        [Required]
        public string OpsName { get; set; }
        [MaxLength(15)]
        [Required]
        public string PhoneNum { get; set; }
        [MaxLength(100)]
        [Required]
        public string Address { get; set; }
        [MaxLength(30)]
        [Required]
        public string EmailId { get; set; }
    }
}
