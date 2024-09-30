
using System.IO;
using CollegeManagement;
public class FileAndFolderHandler
{
    string filePath = @"D:\AppSoft\EnrollmentBatchAug28\BasicApp\FileIO\Data\student.txt";
    FileInfo FInfo => new(filePath);

    public void CreateFile()
    {
        try
        {
            File.WriteAllText(filePath, "This file contains reports on students of DEC");                        
            Console.WriteLine($"{FInfo.Name} created successfuly.");
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void ReadFile()
    {
        var content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }

    public void CreateFolder(string newFolder)
    {
        var folderPath = Path.Combine(FInfo.DirectoryName, newFolder);
        Directory.CreateDirectory(folderPath);
    }

    public void ReadCsv()
    {
        var csvPath = Path.Combine(FInfo.DirectoryName, "students.csv");
        var lines = File.ReadAllLines(csvPath);
        // Need to print name and dobs        

        // header
        var header = lines[0];
        var headerParts = header.Split(",");
        Console.WriteLine($"{headerParts[0]}\t\t{headerParts[2]}");

        // data
        List<student> students = [];
        foreach(var dataLine in lines.Skip(1))
        {            
            var dataParts = dataLine.Split(",");
            var rollNumber = int.Parse(dataParts[1]);
            var dob = DateTime.Parse(dataParts[2]);
            var student = new student(dataParts[0], rollNumber, dob, 'M');
            students.Add(student);
        }
    }
}
