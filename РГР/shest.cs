using System;
using System.Runtime.ConstrainedExecution;
class Shest
{
    static void Main()
    {
        bool conflict = false;
        string first = Console.ReadLine();
        string[] a_first = first.Split(" ");
        int n = Convert.ToInt32(a_first[0]);
        int m = Convert.ToInt32(a_first[1]);

        int[,] datasize = new int[n, 2];
        int[,] data = new int[m, 2];

        // Обработка информации о размере шестеренок
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            string[] a_s = (s.Split(" "));
            int a0 = Convert.ToInt32(a_s[0]);
            int a1 = Convert.ToInt32(a_s[1]);
            datasize[a0 - 1, 0] = a1;
        }

        // Обработка информации о соед.
        for (int i = 0; i < m; i++)
        {
            string ss = Console.ReadLine();
            string[] a_ss = (ss.Split(" "));
            data[i, 0] = Convert.ToInt32(a_ss[0]);
            data[i, 1] = Convert.ToInt32(a_ss[1]);
            datasize[data[i, 0]-1, 1]++;
            datasize[data[i, 1]-1, 1]++;
        }
        // Обработка предпоследней строки.
        string lol = Console.ReadLine();
        string[] a_lol = lol.Split(" ");
        int start = Convert.ToInt32(a_lol[0]);
        int finish = Convert.ToInt32(a_lol[1]);
        string curss = Console.ReadLine();
        curss = curss.Replace(" ", "");
        int curs = Convert.ToInt32(curss);

        // создаю заполняю массив информацией о взаиомдействиях
        int[][] ar_link = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ar_link[i] = new int[datasize[i, 1] + 2];
            ar_link[i][0] = 0; ar_link[i][1] = datasize[i, 1];
        }
        for (int i = 0;i < m; i++)
        {
            int a = data[i, 0];
            int b = data[i, 1];

            ar_link[a - 1][1 + ar_link[a-1][1]] = b;
            ar_link[b - 1][1 + ar_link[b-1][1]] = a;
            ar_link[a - 1][1]--;
            ar_link[b - 1][1]--;
        }

        ar_link[start - 1][0] = curs;

        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                int per = datasize[i, 1];
                if ((ar_link[i][0] != 0) && (per != 0))
                {
                    int cu = ar_link[i][0];
                    while (per != 0)
                    {

                        int j = ar_link[i][1 + per] - 1;
                        if ((ar_link[j][0] != 0) && (ar_link[j][0] != cu * -1)) conflict = true;
                        else ar_link[j][0] = cu * -1;
                        per--;
                    }
                }
            }
        }
        if (conflict) Console.WriteLine("N0");
        else
        {
            double result1 = datasize[start - 1, 0];
            double result2 = datasize[finish - 1, 0];
            double result = result1 / result2;
            Console.WriteLine("YES");
            Console.WriteLine(ar_link[finish - 1][0]);
            Console.WriteLine(result);
        }
    }
}
