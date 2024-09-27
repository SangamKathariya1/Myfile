//LINQ -Language  integrated query
//Used for querying collections

public class LINQ
{
    int[]marks =[23,24,45,12,70,66,50,80];

    List<Student> students = new List<Student>
[
    new Student("Ramesh", 12, new DateTime(2000, 2, 3), 'M'),
    new Student("Suresh", 13, new DateTime(2006, 5, 12), 'M'),
    new Student("Mukesh", 14, new DateTime(2002, 7, 19), 'M'),
    new Student("Mahesh", 15, new DateTime(2010, 8, 21), 'M'), // Added comma
    new Student("Ganesh", 16, new DateTime(2004, 9, 15), 'M')  // Added comma
];

    public void Test()
    {
        //Get  list of pass marks only(40  or more)
        //imperative way

        List<int>passMarks =[];
        foreach(var mark in marks)
        {
            if(mark >=40)
            {
                passMarks.Add(mark);
            }
        }

        //Declarative way
        var pMarks = marks.Where(mark=>mark>=40);

        //Get sum of passmarks
        var totalMarks = marks.Where(mark=>mark>=40).Sum();

        //Get all marks out of 10
        var marks10 = marks.Select(mark=>(double)mark/10);




        //get all passmarks out of 10

      var pMarks10 = marks.Where(mark=>mark>=40).Select(marks=>(double) marks /10);


      //LINQ syntax Method syntax and Expression syntax

      pMarks10 = from mark in marks where mark>=40 select (double)mark/10;




      //get all male student

      var maleStudents= students.Where(s=>s.Gender=='M');


      //Get student names who are adults  now

      var sNames= students.Where(s=>(DateTime.Now - s.dateofBirth).TotalDays/365>=18).Select(s=>s.name);
    } 


}