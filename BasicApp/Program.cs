// OOP: Object oriented programming with c#
//Static vs Dynamic
// OOP vs Functional vs Procedural
//C#:Multi paradigm language
//imperative vs Declarative

// var x= 12334 ;
// Console.WriteLine("personAge");

// var student1 =new Student();
// student1.name="Sangam Kathariya";
// student1.rollNumber= 12;
// student1.dateofBirth = new DateTime(2001,4,14);
// student1.PrintDetails();

using System.Data.SqlTypes;

Console.WriteLine($"Name \t Rollnumber \t Date Of Birth  \t Resume \t Gender");
Student student = new();
 student.name = "Sangam";
student.rollNumber = 1;
student.dateofBirth=new DateTime(1998,05,22);
student.resume = "BCA";
student.Gender = 'M';
student.Info();

Student student1 = new();
 student1.name = "Smith";
student1.rollNumber = 2;
student1.dateofBirth=new DateTime(2000,11,15);
student1.resume = "BE";
student1.Gender = 'M';
student1.Info();


Student student3 = new();
 student3.name = "Virat";
student3.rollNumber = 3;
student3.dateofBirth=new DateTime(1999,05,02);
student3.resume = "BBA";
student3.Gender = 'M';
student3.Info();
