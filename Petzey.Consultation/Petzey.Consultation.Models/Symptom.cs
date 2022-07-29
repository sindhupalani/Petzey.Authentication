using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Consultation.Models
{
    public class Symptom
    {
        [Key]
        public int SymptopmId { get; set; }

        [MaxLength(50)]
        [Required]
        public string SymptomName { get; set; }
        public Appointment AppointmentDetails { get; set; }
    }
}
