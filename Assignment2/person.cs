public class Person(string n, int d, char g)
{
    public string name = n;
    public int age= d;
    public char gender = g;

    public virtual void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{age}\t\t{gender}";
        Console.Write(message);
    }
}