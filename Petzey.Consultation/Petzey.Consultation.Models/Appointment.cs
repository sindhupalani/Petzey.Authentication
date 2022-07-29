using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Petzey.Consultation.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required]
        public DateTime ApointmentDateTime { get; set; }
        [MaxLength(50)]
        [Required]
        public string  PetIssues { get; set; }
        [MaxLength(50)]
        public string Reasons { get; set; }

        public Pet.Models.Pet PetDetails { get; set; }
        public Pet.Models.PetParent PetParentDetails { get; set; }
        public Prescription PrescriptionDetails { get; set; }
        public Vitals VitalDetails { get; set; }
        public  Test TestDetails { get; set; }
        public Symptom SymptomDetails { get; set; }


    }
}
