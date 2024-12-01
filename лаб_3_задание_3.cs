using System;
class lab1
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        long maxsum = long.MinValue;
        long localsum = 0;
        int inflastj = 0;
        int j = 0;

        for (int i = 0; i < k; i++)
        {
            j = int.Parse(Console.ReadLine());
            if (j % 2 == 0)
            {

                localsum += j;
                inflastj = 1;
            }
            else
            {
                if (inflastj == 1)
                {
                    maxsum = Math.Max(maxsum, localsum);
                    inflastj = 0;
                    localsum = 0;
                }
            }

        }
        if (maxsum == long.MinValue)
        {
            if (inflastj == 0) Console.WriteLine("Чётных чисел нет");
            else
            {
                Console.WriteLine(localsum);
            }
        }
        else
        {
            if (j % 2 == 0)
            {
                maxsum = Math.Max(maxsum, localsum);

            }
            Console.WriteLine(maxsum);
        }
    }
}
    

