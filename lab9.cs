using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string start_stroka = Console.ReadLine().Trim();
        start_stroka = start_stroka.Replace("  "," ").Replace("  ", " ");
        string[] slova = start_stroka.Split(' ');
        start_stroka = string.Join(" ", slova);
        Console.WriteLine(start_stroka);

        int kolvo = 0;

        foreach (var slovo in slova)
        {
            var naoborot = new string(slovo.Reverse().ToArray());
            if (slovo == naoborot)
            {
                Console.WriteLine(slovo);
            }
            if (char.ToLowerInvariant(slovo[0]) == char.ToLowerInvariant(slovo[slovo.Length - 1]))
            {
                kolvo++;
            }
        }

        Console.WriteLine(kolvo);
    }
}
