using System;
class lab1
{
    static void Main()
    { 
        Console.WriteLine("Впишите 1 число");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Впишите 2 число");
        int y = Convert.ToInt32(Console.ReadLine());
        x = (x + y) - (Math.Abs(x - y));
        x = x / 2;
        Console.WriteLine("Наименьшим оказалось число  " + x);
    }
}
