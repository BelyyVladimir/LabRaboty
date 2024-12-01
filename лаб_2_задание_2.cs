using System;
class zdn
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine()); 
        int m1 = 0;
        int m2 = 0;
        for (int i = 1, k = 0; i <= a; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            if (i == 1) m1 = m2 = k;
            else if (i == 2)
            {
                if (k > m1) m1 = k;
                else m2 = k;
            }
            else if (k >= m1) { m2 = m1; m1 = k; } 
        }
        Console.WriteLine(m2);
    }
}
