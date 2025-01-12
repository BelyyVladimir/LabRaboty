using System;

class Lab5
{
    public static void Main()
    {
       
        
        int n = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int[n];
        for (int i = 0; i < n; i++)
        {
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }


        bool sort = true;
        for (int i = 1; i < n; i++)
        {
            if (mas[i] <= mas[i - 1]) {sort = false; break;}
            
        }
        if (sort) Console.WriteLine("отсортирован");
        else Console.WriteLine("не отсортирован");


        int k = 0;
        for(int i = 0;i < n;i++)
        {
            int j = mas[i];
            if (Math.Abs(j % 10) == 3) k++;
        }
        Console.WriteLine($"на 3 заканчивается {k} эл.");

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = mas[i];
            sum = 0;
            while (num != 0)
            {
                sum += Math.Abs(num % 10);
                num /= 10;
            }
            Console.WriteLine($"{i + 1}. сумма - {sum}");
        }
  
        sum = 0;
        k = 0;
        for (int i = 0; i < n; i++)
        {
            if (mas[i] % 2 == 0)
            {
                k++;
                sum += mas[i];
            }
        }
        if (k == 0) Console.WriteLine("Нет чётных");
        else Console.WriteLine(sum * 1.00 / k);
    }
}
