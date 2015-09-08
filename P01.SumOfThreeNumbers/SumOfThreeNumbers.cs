using System;
using System.Threading;
using System.Globalization; //Adding both systems because of the decimal sign which could be dot or comma.

class SumOfThreeNumbers
{
    static void Main()
    {
        string columnA = "a";
        string columnB = "b";
        string columnC = "c";
        string columnResult = "sum";

        Console.WriteLine("{0,-10}" + '|' + "{1,-10}" + '|' + "{2,-10}"  + '|' + "{3,-10}" + '|' , columnA, columnB, columnC, columnResult);
        Console.WriteLine("Please, hit \"Enter\" after each entered number!");
        
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //string str = Console.ReadLine();
        //str = str.Replace(",", ".");
    
        double aNum = double.Parse(Console.ReadLine());
        double bNum = double.Parse(Console.ReadLine());
        double cNum = double.Parse(Console.ReadLine());
        
        Console.WriteLine("{0,-10:F2}" + '|' + "{1,-10:F2}" + '|' + "{2,-10:F2}" + '|' + "{3,-10:F2}" + '|', aNum, bNum, cNum, aNum+bNum+cNum);
    }
}

