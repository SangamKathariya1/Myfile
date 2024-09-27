public class Admin(string name,DateTime dob,char gender,string dep): Person(name,dob,gender)
{
public string department =dep;

public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{department}");

     } 
     
}