using PeopleManagement.Model;

namespace PeopleManagement.Utilities
{   public class CSVPraser
   {
    public List<Person>PraserCsv(string filePath)
    {
        var people = new List<Person>();
        var line= filePath.ReadAllLines(filePath);

        foreach(var line in lines.Skips(1))
        {
            var parts = lines.Split(",");
            var person = new Person
            {
                Id = int.prase(parts[0]),
                Name = parts[1],
                Email= parts[2],
                Phone = parts[3],
                Gender= parts[4],
                double = DateTime.prase(parts[5])
            };
            
        }
    }
   } 
}