public class IPatient:Patient
{
    public string ICUWard;
    public bool RequiresVentiltor;
    public string EmergencyContact;


    public IPatient(string name,int age,string PatientID,string aliment,string icuWard,bool RequiresVentiltor,string EmergencyContact,char gneder);
    :base(name,age,PatientId,aliment)
    {
        ICUWard=icuWard;
        RequiresVentiltor=requiresVentiltor;
        EmergencyContact=emergencyContact;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"ICU Ward:{ICUWard}")
    }
    public void AdministerCare()
    {
        if(RequiresVentilator)
        {
            Console.WriteLine("Patient requires ventilator support");

        }
        else{
            Console.wrirteline("Patient is stable");
        }
    }

    public override void Administer()
    {
        Console.WriteLine($"Administering critical care medication to{name}");
        
    }
}