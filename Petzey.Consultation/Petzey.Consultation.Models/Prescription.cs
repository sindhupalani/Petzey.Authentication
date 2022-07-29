using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Consultation.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }
        [MaxLength(30)]
        [Required]
        public string  MedicineName { get; set; }
        public Appointment AppointmentDetails { get; set; }

        [Required]
        public int Duration { get; set; } // no of days

        [MaxLength(30)]
        [Required]
        public string Dosage { get; set; } // Morning/after

        [MaxLength(30)]
        [Required]
        public string Consume { get; set; } // before/after meal
        [MaxLength(100)]
        public string Comments { get; set; }

    }
}
