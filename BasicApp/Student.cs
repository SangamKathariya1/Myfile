class Student
{
    public string name;
    int rollNumber;
    public DateTime dateofBirth;
    char Gender;

    void DetilPrint()
    {
        Console.WriteLine(name);
        Console.WriteLine(rollNumber);
        Console.WriteLine(dateofBirth.ToLongDateString);
    }
}
