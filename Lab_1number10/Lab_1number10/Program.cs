using System;

namespace Lab_1number10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название 1 телепередачи");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ФИО 1 ведущего");
            string initils = Console.ReadLine();
            Console.WriteLine("Введите рейтинг 1 телепередачи (От 0 до 5)");
            int rating = Convert.ToInt32(Console.ReadLine());
            if (rating>5 | rating<0)
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Введите тип 1 телепередачи (И, А или Т)");
            string format = Console.ReadLine();
            Console.WriteLine("Введите название 2 телепередачи");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите ФИО 2 ведущего");
            string initils1 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг 2 телепередачи (От 0 до 5)");
            int rating1 = Convert.ToInt32(Console.ReadLine());
            if (rating1 > 5 | rating < 0)
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Введите тип 3 телепередачи(И, А или Т)");
            string format1 = Console.ReadLine();
            Console.WriteLine("Введите название 3 телепередачи");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите ФИО 3 ведущего");
            string initils2 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг 3 телепередачи (От 0 до 5)");
            int rating2 = Convert.ToInt32(Console.ReadLine());
            if (rating2 > 5 | rating < 0)
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Введите тип 3 телепередачи (И, А или Т");
            string format2 = Console.ReadLine();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("|                               Телепередачи                                    |");
            Console.WriteLine("|_______________________________________________________________________________|");
            Console.WriteLine("| Телепередача             |  Ведущий            |  Рейтинг        |  Тип       |");
            Console.WriteLine("|__________________________|_____________________|_________________|____________|");
           Console.WriteLine($"|{name}                    |  {initils}          | {rating}        |{format}    |");
            Console.WriteLine("|__________________________|_____________________|_________________|____________|");
           Console.WriteLine($"|{name1}                   |  {initils1}         | {rating1}       |{format1}   |");
            Console.WriteLine("|__________________________|_____________________|_________________|____________|");
           Console.WriteLine($"|{name2}                   |  {initils2}         | {rating2}       |{format2}   |");
            Console.WriteLine("|__________________________|_____________________|_________________|____________|");
            Console.WriteLine("|     Пересчисляемый тип: И - игровая;  А - аналитическая; Т – ток-шоу          |");
            Console.WriteLine("|_______________________________________________________________________________|");






        }
    }
}
