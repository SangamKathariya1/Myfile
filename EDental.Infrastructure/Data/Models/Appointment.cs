using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; } 
        public TimeSpan Time { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public string Remarks { get; set; }// Additional notes

    }
}
