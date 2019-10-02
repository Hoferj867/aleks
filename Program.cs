using System;

namespace Lab_1number1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double whole = (int) x;
            whole = (x- whole) *10;
            int d = Convert.ToInt32(whole);
            Console.WriteLine(d);
        }

    }
}
