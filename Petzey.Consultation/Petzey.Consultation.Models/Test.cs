using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Consultation.Models
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }

        [MaxLength(50)]
        [Required]
        public string TestName { get; set; }
        public Appointment AppointmentDetails { get; set; }
    }
}
