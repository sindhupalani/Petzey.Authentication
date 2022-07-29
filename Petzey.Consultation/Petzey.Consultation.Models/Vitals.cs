using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Consultation.Models
{
    public class Vitals
    {
        [Key]
        public int VitalId { get; set; }

        [Required]
        public int Heatbeat { get; set; }

        [Required]
        public int Temperature { get; set; }

        [Required]
        public int BloodPressure { get; set; }
        public Appointment AppointmentDetails { get; set; }
    }
}
