using System;

namespace Lab_1number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины двух катетов a и b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int s = (a * b) / 2;
            int c = (a * a) + (b * b);
            int p = a + b + c;
            Console.WriteLine($"площадь = {s}; периметр = {p}");
        }
    }
}
