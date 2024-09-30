namespace CollegeManagement;
public class Person(string n, DateTime d, char g)   // Primary Constructor
{
    public string name = n;
    public DateTime dateOfBirth = d;
    public char gender = g;

    public string Resume { get; set; } = string.Empty;

    public virtual void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.Write(message);
    }
}