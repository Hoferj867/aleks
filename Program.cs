using System;

namespace Lab_1number6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4-значное число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 999 & num < 10000)
            {
                int thousand = num / 1000;
                num = num % 1000;
                int hundredth = num / 100;
                num = num % 100;
                int tenth = num / 10;
                num = num % 10;
                int sum = thousand * hundredth * tenth * num;
                Console.WriteLine($"Произведение = {sum}");
            }
            else
            {
                Console.WriteLine("Число не 4-значное");
            }
        }
    }
   }
