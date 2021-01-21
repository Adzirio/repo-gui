using System;

namespace Task2
{
    class Program
    {
        enum Month 
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Практическое задание №2.2\nОпределение месяца по порядковому номеру.");
            Console.Write("Введите порядковый номер месяца: ");
            string i = Console.ReadLine();
            int monthAnswer = Convert.ToInt32(i);
            Month curentMonth = (Month)monthAnswer;
            Console.WriteLine("Данному номеру соответствует месяц: " + curentMonth);
        }
    }
}
