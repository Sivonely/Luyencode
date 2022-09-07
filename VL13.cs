using System;
namespace VL12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            int sum = 0;
            for (int i = 1; i< n; i++)
                if (n % i ==0) sum = sum +i;
            if (n == sum) Console.WriteLine("YES");
                else Console.WriteLine("NO");
             
        }
    }
}