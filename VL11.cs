using System;
namespace VL01
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
           long n = Convert.ToInt64(s);
            if (snt(n)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.WriteLine();
        }
        static bool snt(long n)
        {
            for(int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
            {
                if (n % i == 0) return false;
            }
            return (n >= 2);
        }
    }
}