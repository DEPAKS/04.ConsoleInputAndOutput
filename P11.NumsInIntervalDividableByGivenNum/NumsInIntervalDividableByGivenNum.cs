using System;

class NumsInIntervalDividableByGivenNum
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);

        //if (count > 0)
        //{
        //    Console.WriteLine(count);
        //}
        //else
        //{
        //    Console.WriteLine("-");
        //}
    }  
}

