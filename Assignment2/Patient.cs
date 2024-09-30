public class Patient: Person,IMedicine
{
    public string PatientId;
    public string Aliment;
    public List<string> prescribedMedicine;



public Patient(string name,string patientId,int age,string aliment,char gender)
:base(name,age)
{

    PatientId= patientId;
    Aliment= aliment;
    prescribedMedicine =new List<string>();
}



public override void PrintDetails()
{
    Console.WriteLine($"patient:{name},Age:{age},ID:{PatientId},Aliment:{Aliment},gender:{gender}");

} 


// implementing IMedicine methods
    public string GetMedicineName()
    {
        if(prescribedMedicine.Count>0)
        {
            return prescribedMedicine[0];

        }
        else{
            return "No Medicine prescribed";
        }
    }

    public string GetDose()
    {   
        return "Take 2 tablet  daily";

    }
    public List<string> GetSideEffect()
    {
        return new List<string>{"HeadAche","Thoyphoid"};
    }

    public bool IsExpeired(DateTime expiryDate)
    {
        return DateTime.Now>expiryDate;
    }
    public void Administer()
    {
        Console.WriteLine($"Administering{GetMedicineName()}to the patient");
    }
}
