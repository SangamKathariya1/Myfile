using System.IO;
using Microsoft.VisualBasic;

public class FileAndFolderHandler
{
    string filePath = @"E:\Tranning\MyFiles\BasicApp\FileIO\Data\student.txt";
    FileInfo FInfo => new(filePath);
    public void CreateFile()
    {
        
        try{
                 FileInfo fi= new FileInfo(filePath);
                 File .WriteAllText(filePath,"This file contains reports on student of NAST");
                 Console.WriteLine($"{fi.Name} Created Sucessfully");
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
        var folderPath = Path.Combine(FInfo.DirectoryName,newFolder);
        Directory.CreateDirectory(folderPath);
    }
    public void ReadCsv()
    {
      var csvpath =Path.Combine(FInfo.DirectoryName,"Student.csv");
        var lines = File.ReadAllLines(filePath);
        // Need to print name and dobs
        var header = lines[0];
       var headerParts = header.Split(",");
        Console.WriteLine($"{headerParts[0]}\t\t{headerParts[2]}");
    }
/// data
      List<Student> students = new List<Student>();
foreach (var dataline in lines.Skip(1))
{
    var dataParts = dataline.Split(","); 
    int rollNumber = int.Parse(dataParts[1]); 
    var student = new Student(dataParts[0], rollNumber, dataParts[3], 'M');
    
    students.Add(student);
}

}

