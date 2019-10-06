using System;

namespace Lab_1number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3-значное число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 99 & num<1000)
                {
                int hundredth = num / 100;
                num = num % 100;
                int tenth = num / 10;
                num = num % 10;
                int reversed = (num * 100) + (tenth * 10) + hundredth;
                Console.WriteLine($"Перевёрнутые 3-значное чило:{reversed}");
            }
            else
            {
                Console.WriteLine("Число не трёхзначное!");
            }
        }
    }
}
