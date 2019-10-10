using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите t");
            double t = Convert.ToDouble(Console.ReadLine());
            double e = 2.718;
            double y = (Math.Pow(e, -b * t) * Math.Sin(a * t + b) - Math.Sqrt(Math.Abs(b * t + a)));
            double s = (b * Math.Sin(a * Math.Pow(t, 2) * Math.Cos(2 * t)) - 1);
            Console.WriteLine($"y={y} s={s}");

        }
    }
}
