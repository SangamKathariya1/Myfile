using System;
using System.Collections.Generic;

public class Dentist : Person, IMedicine
{
    // Properties
    public string LiscenceNumber;
    public string ClinicName;
    public string Specialist;

    // Constructor
    public Dentist(string name, string liscenceNumber, int age, string clinicName, string specialist, char  gender)
        : base(name, age)  
    {
        Name = name;                
        LiscenceNumber = liscenceNumber;
        ClinicName = clinicName;
        Specialist = specialist; 
        gender= gender;
        Age = age;                    
    }

    // Overriding PersonInfo method
    public override void PrintDetails ()
    {
        Console.WriteLine($"Dentist: {name}, Age: {age}, License:{LiscenceNumber}, Clinic: {ClinicName}, Gender: {gender}, Specialist: {Specialist}");
    }

    // Implementing IMedicine methods
    public string GetMedicineName()
    {
        return "Pain Reliever";
    }

    public string GetDose()
    {
        return "Take 2 tablets morning and evening with meals.";
    }

    public List<string> GetSideEffect()
    {
        return new List<string> { "Headache", "Typhoid" };
    }

    public bool IsExpired(DateTime expiryDate)
    {
        return DateTime.Now > expiryDate;
    }

    public void Administer()
    {
        Console.WriteLine("Administering Pain Reliever.");
    }
}
