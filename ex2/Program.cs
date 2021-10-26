using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, ch, zn, a,
                S = 0, 
                p = 1, 
                d = 1;
            int k = 0;
            Console.Write("Enter x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Intermediate results");
            a = x;

            while (Math.Abs(a) >= 0.000001)
            {
                S += a;
                //ch
                ch = x * d;
                d = x * d;
                Console.WriteLine("Ch = " + ch);
                //zn
                zn = 2.0 * p;
                p = 2.0 * p;
                Console.WriteLine("Zn = " + zn);
                a = ch / zn;
                k++;
                Console.WriteLine($"Iteration #{k}");
                Console.WriteLine($"a = {a} \t S = {S}");
            }
            y = x / (2d - x);
            Console.WriteLine("\n   Results:");
            Console.WriteLine($"Given x = {x}");
            Console.WriteLine($"The calculated sum of the series S = {S}");
            Console.WriteLine($"Number of members of the row {k}");
            Console.WriteLine($"Function x/(2-x) = " + y);
            Console.ReadKey();
        }
    }
}
