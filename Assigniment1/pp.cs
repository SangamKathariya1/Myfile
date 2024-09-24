using system
class program
{
    static void main()
    {
        console.write("Enter Electricity bill consumed")
        int units =int.prase(console.Readline());
         int totalAmount= CalculateBill(units);

         console.writeline($"total amount to be paid is: Rs{total amount}");
    }
    static int CalculateBill(int unit){
        switch(units)

        {

            case int n when(n<=20);

            return 100;

            case int n when(n<=25);

            return 100+(units-20)*5;

            case int n when(n<=50);
            
            return 100+(5*5)+(uints-25)*10;
             default:
             return 2000;
        }
    }

}