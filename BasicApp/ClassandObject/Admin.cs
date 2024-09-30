namespace CollegeManagement;
public class Admin(string name, DateTime dob, char gender, string dep) :
    Person(name, dob, gender), IAdmin
{
    public string department = dep;

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{department}");
    }

    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tDepartment";
        Console.WriteLine(header);
    }

    public List<string> GetRoles() => ["Attendence", "Cirricular Activities"];
}