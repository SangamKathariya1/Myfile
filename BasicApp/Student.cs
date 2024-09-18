class Student
{
    public string name;
    int rollNumber;
    public DateTime dateofBirth;
    char Gender;

    void PrintDetails()
    {
        Console.WriteLine(name);
        Console.WriteLine(rollNumber);
        Console.WriteLine(dateofBirth.ToLongDateString);
    }
}
