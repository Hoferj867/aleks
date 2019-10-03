using System;

namespace lab_1number2
{
    class Program
    {
        static void Main(string[] args)
        {

            int secondspassed = Convert.ToInt32(Console.ReadLine());
            int hour1 = (secondspassed % 3600);
            int hour = (secondspassed / 3600);
            int seconds = (secondspassed % 60);
            int minuts = (hour1 / 60);
            Console.WriteLine($"Часы: {hour} Минуты: {minuts} Секунды: {seconds}" );
           
        }
    }
}
