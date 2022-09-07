using System;
namespace VL12
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            int c = ncln(a,b);
            Console.Writeline(c);
            Console.ReadLine();
            
             
        }
        static int ucln(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            if ((x == 0) && (y !=0)) return y;
            if ((y == 0) && (x !=0)) return x;
            if (x > y) return ucnl(x % y,y);
            else return ucnl(x,y%x);
        }
    }
}