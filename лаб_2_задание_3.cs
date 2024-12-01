using System;
class zdn
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine()); 
        int s = 0;
        for (int i = 1, k = 0, cl = 0, c = 0, cr = 0; i <= a; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            if (i == 1) c = k; 
            else if (i == 2) cr = k;
            else
            {
                cl = c;
                c = cr;
                cr = k;
                if ((cl > c) && (c < cr)) s++;
            }
        }
        Console.WriteLine(s);
    }
}
