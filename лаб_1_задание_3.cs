using System;
class lab1
{
    static void Main()
    { 
        int k, m, l, n, o1, o2, o3, sum;
Console.WriteLine("Введите расстояние от колодца до грядок.");
k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину грядки.");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину грядки");
l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во грядок");
n = Convert.ToInt32(Console.ReadLine());

o1 = 2 * n * k; //расстояние от колодца до грядки
o2 = 2 * n * (m + l); // расстояние по периметру грядок 
o3 = l * n * (n - 1); // расстояние от начала грядок до каждой грядки
sum = o1 + o2 + o3; ; // сумма расстояний

Console.WriteLine(sum);
    }
}
