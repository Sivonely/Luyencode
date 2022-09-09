using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] s = new string[1000000];
            do
            {
                i++;
                s[i] = Console.ReadLine();
            } while (s[i] != "");
            for(int j = 0; j <= i; j++)
            {
                if (s[j][0] == s[j][s[j].Length - 1]) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
           
        }
    }
}
