using system;
using System.Runtime.InteropServices;
class intens
{
    static void Main()
    {
        string[] date1 = Console.ReadLine().Split('.');
        string[] date2 = Console.ReadLine().Split('.');
        int start_number = int.Parse(Console.ReadLine());
        DateTime d1 = new DateTime(int.Parse(date1[2]), int.Parse(date1[1]), int.Parse(date1[0]));
        DateTime d2 = new DateTime(int.Parse(date2[2]), int.Parse(date2[1]), int.Parse(date2[0]));
        TimeSpan t1 = d2 - d1;
        long days = t1.Days;
        Console.WriteLine(start_number * (days + 1) + days * (days + 1) / 2);
    }
}



