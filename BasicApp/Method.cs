using System.Diagnostics.CodeAnalysis;

class Method
{
public  void SayHello ()=> Console.Write("Hey There!!");

//pass greetings as argument and method overloading
 public void SayHello(String greeting)=> Console.Write(greeting);

 //capitalize greeting message and return to caller
 public string SayHello(string greeting,string details)=>$"{greeting.ToUpper()}\n{details}";

//Average of all number provided

public float GetAverage(params int[] numbers)
{
    int Sum =0;
foreach(var num in  numbers)
{
    Sum+=num;
}
var a =(float)Sum/numbers.Length;
return a;
}

//Modify above method to return sum and average
public (int,float) GetResult(params int[] numbers)
{
    int Sum =0;
foreach(var num in  numbers)
{
    Sum+=num;
}
var a =(float)Sum/numbers.Length;
return (Sum,a);
}
}