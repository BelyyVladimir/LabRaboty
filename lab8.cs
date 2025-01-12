using System;

class Lab8
{
    public static void Main()
    {
        
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] mas = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        PrintAr(mas);

        int maxPos = 0, minPos = 0;
        int maxAr = mas[0, 0], minAr = mas[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (mas[i, j] > maxAr)
                {
                    maxAr = mas[i, j];
                    maxPos = i;
                }
                else if (mas[i, j] < minAr)
                {
                    minAr = mas[i, j];
                    minPos = i;
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            int temp = mas[maxPos, i];
            mas[maxPos, i] = mas[minPos, i];
            mas[minPos, i] = temp;
        }

        PrintAr(mas);
        
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] ar = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        PrintAr(mas);

        int c = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int lineCh = InLine(mas, i, mas[i, j]);
                int columnCh = InColumn(mas, j, mas[i, j]);
                if ((lineCh != columnCh && lineCh != 0 && columnCh != 0) || (lineCh == 2 && columnCh == 2))
                {
                    Console.WriteLine($"Минимакс {mas[i, j]} на позиции ({i+1},{j+1})");
                }
            }
        }
        

        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] ar = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mas[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        int[,] check = new int[n, 3];
        for (int i = 0; i < n; i++)
        {
            check[i, 1] = 1;
            for (int j = 0; j < m; j++)
            {
                check[i, 0] += mas[i, j];
                check[i, 1] *= mas[i, j];
                if (mas[i, j] == 0) check[i, 2] += 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (check[i, 0] == check[j, 0] && check[i, 1] == check[j, 1] && check[i, 2] == check[j, 2])
                {
                    Console.WriteLine($"Пара равных строк: {i}, {j}");
                }
            }
        }
    }

    static void PrintAr(int[,] ar)
    {
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(1); j++)
            {
                Console.Write(ar[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int InLine(int[,] ar, int line, int elem)
    {
        bool max = true;
        bool min = true;
        for (int i = 0; i < ar.GetLength(1); i++)
        {
            if (elem > ar[line, i])
            {
                min = false;
            }
            if (elem < ar[line, i])
            {
                max = false;
            }
        }
        if (max & min) return 2;
        else if (max) return 1;
        else if (min) return -1;
        else return 0;
    }

    static int InColumn(int[,] ar, int column, int elem)
    {
        bool max = true;
        bool min = true;
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            if (elem > ar[i, column])
            {
                min = false;
            }
            if (elem < ar[i, column])
            {
                max = false;
            }
        }
        if (max & min) return 2;
        else if (max) return 1;
        else if (min) return -1;
        else return 0;
    }
}
