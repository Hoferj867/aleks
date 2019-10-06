using System;

namespace Lab_1
{
    class Lab_1nember3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество часов:");
            int hors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество секунд:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            
            double degree = (hors * 30) + (minutes * 0.5) + (seconds*(0.5/60.0));

            Console.WriteLine($"градусов: {degree}");


        }
    }
}
