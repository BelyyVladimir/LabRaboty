using System;

class lab4
{
    public static void Main()
    {
        do
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) break;
            int a = 0;
            bool net = true;
            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    a = a * 10 + n % 10;
                    net = false;
                }
                n /= 10;
            }
            if (net) Console.WriteLine("нет четных");
            else Console.WriteLine(a);
        } while (true);
    }
}
