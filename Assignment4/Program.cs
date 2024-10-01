using PeopleManagement.Utilities;

namespace PeopleManagement
{

class people
{
    static void Main(string[]args)
    {
        var filePath= @"E:\Tranning\MyFiles\Assignment4\People.csv";
        if(!filePath.Exists(filePath))
        {
            console.WriteLine("Filenot found. ");
            return;

        }
             var CSVPraser= new csvParser();
             var people= CSVPraser.PraserCsv(filePath);


            var report= new PeopleReport();
            report.SaveMales(people);
            report.SaveFemale(people);
            report.SaveDotComUsers(people);

            Console.WriteLine("Report generated sucessfully");


         }
    }
}