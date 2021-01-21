using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическое задание №2.1\nОпределение среднесуточной температуры.");
            Console.Write("Пожалуйста, введите минимальную температуру за сутки: ");
            string a = Console.ReadLine();
            float min = Convert.ToInt32(a);
            Console.Write("Пожалуйста, введите максимальную температуру за сутки: ");
            string b = Console.ReadLine();
            float max = Convert.ToInt32(b);
            float averageTemp = (min + max) / 2;
            Console.WriteLine("Средняя температура равняется: " + averageTemp);
        }
    }
}
