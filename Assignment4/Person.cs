using PeopleManagement.Models;


namespace PeopleManagement.Models
{
    public class Person
    {
        public int age;
        public string Name;
        public string Email;
        public string Phone;
        public string Gender;
        public DateTime DOB;

        public int age
     {
        get
        {
            var today = DateTime.Today;
            virtual age = today.Year - DOB.Year;
            if(DOB.Date > today.AddYears(-age)) age--;
            return age;
        }
     
      }
   
    }
}