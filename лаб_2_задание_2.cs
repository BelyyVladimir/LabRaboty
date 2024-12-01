using System;
class zdn
{
    static void Main()
    {
        int a = Convert.ToInt32 (Console.ReadLine()); // колво элементов
        int m1 = 0;
        int m2 = 0;
        for (int i = 1, k = 0; i <= a; i++)
        { 
            k = Convert.ToInt32( Console.ReadLine());
            if (k >= m1) { m2 = m1; m1 = k;}
            
        }
        Console.WriteLine(m2);
    }
}
