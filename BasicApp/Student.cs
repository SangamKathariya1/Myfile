class Student
{
    public string name;
    public  int rollNumber;
    public DateTime dateofBirth;
    public string resume;

    public  char Gender;

    //  public void PrintDetails()
    // {   
    //     // var output = name +","+rollNumber + "," + dateofBirth.ToLongDateString;
    //     // Console.WriteLine(output);
       
    //    // string interpolation

    //    var message = $"{name}\t {rollNumber}\t {dateofBirth.ToLongDateString()}\t {rollNumber}\t{Gender}";
    //    Console.WriteLine(message);
    // }
    public void Info(){
        var message =$"{name}\t{rollNumber}\t{dateofBirth.ToLongDateString()}\t{Gender}\t{resume}";
        Console.WriteLine(message);
    }
}

