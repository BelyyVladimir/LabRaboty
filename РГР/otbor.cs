class Otbor
{ 
    static void Main()
    {
        Console.Write("  Колво солдат: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int k = 1;
        while (k < n) k*=2;
        int res = 0;
        if (k - n <= n - k / 2) res = k - n;
        else res = n - k / 2;
        Console.WriteLine("  Колво групп: " + res);
        Console.ReadKey();
    }
}

