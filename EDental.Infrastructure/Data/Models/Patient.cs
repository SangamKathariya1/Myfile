using EDental.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Data.Models
{
    public class Patient
    {
        // Properties
        public int Id { get; set; }                     
        public string FullName { get; set; }           
        public DateTime DateOfBirth { get; set; }  
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }        
        public string Email { get; set; }             
        public string Address { get; set; }            
        public string MedicalHistory { get; set; }      
        public List<Appointment> Appointments { get; set; } 


    }
}
