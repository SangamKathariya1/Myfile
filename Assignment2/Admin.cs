using System;
public class Admin : Person
{
    public string AdminID;
    public string Department;
     public DateTime DateofJoining;


     public class Admin(string Name,int age,string adminID,string department,DateTime DateofJoining)
     :base (name,age)
     {
        AdminID= adminID;
        Department = department;
        DateofJoining= DateofJoining;
     }



     public override void PrintDetails()
     {
        base.PrintDetails();
        Console.WriteLine($"Admin ID:{AdminID},Department:{Department},Date of joining:{DateofJoining.ToShortDateString()}");
     }

     public  override void DepartmentInfo()
     {
        Console.WriteLine($"Admin{name} works in the {Department}Department");
     }
}







