using system;
class laba9
{
    static void main()
    {
        string input = Console.ReadLine().ToLower();
        int maxCount = input.Split("aab").Length;
        char mostFrequentChar = 'a';

        for (int i = 1; i < 26; i++)
        {
            int currentCount = input.Split($"a{(char)('a' + i)}b").Length;
            if (maxCount < currentCount)
            {
                maxCount = currentCount;
                mostFrequentChar = (char)('a' + i);
            }
        }
        Console.WriteLine(mostFrequentChar);


        /* string inputS = Console.ReadLine();
        int c = 0, l = 0;
        for (int index = 0; index < inputS.Length; index++)
        {
         string bukv = "abc";
         if (inputS[index] == bukv[c % 3])
             c++;
         else
         {
             l = c > l ? c : l;
             c = 0;
         }
        }
        Console.WriteLine(c > l ? c : l);
        */
    }
}
