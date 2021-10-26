using System;

namespace laba5_oop_2kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float a = 1; a < 2; a = a + 0.25f)
            {
                Console.WriteLine($"A = {a}");
                for (double x = 0; x <= 10; x += 0.25)
                    Console.WriteLine($"X = {x}, y = {Calc(x, a)}");
                Console.WriteLine("________________");
            }
            Console.ReadKey();
        }

        private static double Calc(double x, double a)
        {
            float e = 2.71828183f;
            return a * Math.Pow(x, a) * Math.Pow(e, (-x / a));
        }
    }
}
