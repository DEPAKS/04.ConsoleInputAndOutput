using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please, enter the radius of the circle and then, press \"Enter\": ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r; //Math.PI = числото Пи; формулата за периметър на кръг.
        double area = Math.PI * Math.Pow(r,2); //Math.Pow повдига посоченото от нас число на, в случая "r", на дадена степен, в случая "2".

        Console.WriteLine("perimeter = {0:00.00}",perimeter);
        Console.WriteLine("area = {0:00.00}", area);
    }
}

