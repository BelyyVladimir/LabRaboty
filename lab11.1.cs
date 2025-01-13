using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
class construct
{

    public int a, b;

    public construct()
    {
        a = 0;
        b = 0;
    }

    public construct(int x)
    {
        a = x;
        b = 0;
    }

    public construct(int x,int y)
    {
        a = x;
        b = y;
    }

    public void sum()
    {
        Console.WriteLine(a + b);
    }

    public void raz() 
    { 
        Console.WriteLine(a - b);
        Console.WriteLine(b - a);
    }

    public void um()
    {
        Console.WriteLine(a * b);
    }

    public void del()
    {
        if (b != 0) Console.WriteLine((double)a / b);
        else Console.WriteLine("деление невозможно");
    }
}
class main
{
    static void Main()
    {
        Console.WriteLine("ввод чисел");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        
        construct fi = new construct();
        construct se = new construct(x);
        construct th = new construct(x,y);

        Console.WriteLine("результат 1");
        fi.sum(); fi.raz(); fi.um();fi.del();
        Console.WriteLine("результат 2");
        se.sum(); se.raz(); se.um(); se.del();
        Console.WriteLine("результат 3");
        th.sum(); th.raz(); th.um(); th.del();
    }
}

