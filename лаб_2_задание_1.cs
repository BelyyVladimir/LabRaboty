using System;
class zdn
{
    static void Main()
    {
        int a = Convert.ToInt32 (Console.ReadLine()); // колво элементов
        int j = 0;// колво эл меньше нуля в итоге
        for (int i = 1,k; i <= a; i++)
        { 
            k = Convert.ToInt32( Console.ReadLine());
            if (k < 0) { j++; }
            
        }
        Console.WriteLine(j);
    }
}
