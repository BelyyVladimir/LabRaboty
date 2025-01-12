using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
class lab3
{
    static int[] fmas(int[] massiv)
    {
        int i = 0;
        while (i < massiv.Length) { massiv[i] = Convert.ToInt32(Console.ReadLine()); i++; }
        return massiv;

    }

    static int fkr3(int[] massivk)
    {
        int i = 0;
        int sum = 0;
        while (i < massivk.Length)
        {
            if (((massivk[i]) % 3) == 0) { sum += massivk[i]; }
            i++;
        }
        return sum;


    }
    static int fpr(int[] massivp)
    {
        int i = 0;
        int pr = 1;
        while (i < massivp.Length)
        {
            if (((massivp[i]) % 2) == 1) { pr *= massivp[i]; }
            i++;
        }
        return pr;

    }
    static int fnull(int[] massivn)
    {
        int i = 0;
        int knull = 0;
        while (i < massivn.Length)
        {
            if ((massivn[i]) == 0) { knull++; }
            i++;
        }
        return knull;

    }
    public static void Main()
    {

        Console.WriteLine("введите колво элементов в 1 массиве");
        int c1 = Convert.ToInt32(Console.ReadLine());
        int[] massiv1 = new int[c1];
        massiv1 = fmas(massiv1);


        Console.WriteLine("введите колво элементов в 2 массиве");
        int c2 = Convert.ToInt32(Console.ReadLine());
        int[] massiv2 = new int[c2];
        massiv2 = fmas(massiv2);

        Console.WriteLine("введите колво элементов в 3 массиве");
        int c3 = Convert.ToInt32(Console.ReadLine());
        int[] massiv3 = new int[c3];
        massiv3 = fmas(massiv3);

        Console.WriteLine("СУММА");
        Console.WriteLine("1. " + fkr3(massiv1));
        Console.WriteLine("2. " + fkr3(massiv2));
        Console.WriteLine("3. " + fkr3(massiv3));
        Console.WriteLine("ПРОИЗВЕДЕНИЕ");
        Console.WriteLine("1. " + fpr(massiv1));
        Console.WriteLine("2. " + fpr(massiv2));
        Console.WriteLine("3. " + fpr(massiv3));
        Console.WriteLine("КОЛВО НУЛЕЙЙ");
        Console.WriteLine("1. " + fnull(massiv1));
        Console.WriteLine("2. " + fnull(massiv2));
        Console.WriteLine("3. " + fnull(massiv3));
    }
}
