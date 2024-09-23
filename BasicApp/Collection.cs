using System.Security.Cryptography.X509Certificates;

class Collection
{
    //Learn about arrays
    public void LearnArrays()
    {
        string[] names= new string[10];
        names[0]="Sangam";
        //..
        int[]ages =[23,24,22,45];
    }


    public void LearnList()
    {
        // List<string> names = new();
        // names.Add("Rakesh");

        List<string>names =["Sangam"];
    }
     public void  LearnDictionary()
        {
            //key value pairs
            //store country name and its population
         Dictionary<string,long> countryPopulation = new();
         countryPopulation.Add("Nepal",23424422); 
         countryPopulation.Add("India",334555344);     
        }
}