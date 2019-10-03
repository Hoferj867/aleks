using System;

namespace Lub_1number4
{
    class number4
    {
        static int x = Convert.ToInt32(Console.ReadLine());
        static int y = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            x += y;
            y -= x;
            x += y;
            y *= -1;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
}
