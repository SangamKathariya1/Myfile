using PeopleManagement.MOdel;
 namespace PeopleManagement.Utilities
 {
    public class PeopleReport
    {
       public void SaveMales(List<Person>people)
       {
         var males= People.where(p =>p.Gender == "Male").ToList();
        var filePath ="males.csv";
        //write each directory name  to a file
         using(var writer =new StreamWriter(filePath))
         {
                writer.WriteLine("Id,Name,Email,Phone,Gender,DOB");
            
            foreach(var males in males)
            {
                write.WriteLine($"{male.Id},{male.Name},{male.Email},{male.Gender},{male.DOB:yyyy-mm-dd}");

            }
         }
         
       }
       public void SaveFemale(List<Person>people)
         {
            var AdultFemales=People.where(p=>p.Gender=="Female"&& p.Age>=18).ToList();
            var filePath= "adultfemales.csv";


            using (var writer =new StreamWriter(filePath))
            {
                foreach(var female is AdultFemales)
                {
                    Writer.WriteLine($"{female.Id},{female.Name},{female.Email},{female.phone},{female.DOB:yyyy-mm-dd}")

                }
            }
         } 
        public void SaveDotComUsers(List<Person>people)
        {
            var dotComUser = people.where(people=>people.Email.EndsWith("sangamkathariya1")).ToList();
            var filePath =" dotComUser.csv";

            using(var writer = new streamWriter(filePath))
            {
                writer.WriteLine("Id,Email,Phone");
                foreach(var user in dotComUser)
                {
                    writer.WriteLine($"{user.Id},{user.Name},{user.Email}");
                }
            }
        }


    }
 }