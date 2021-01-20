using System;

namespace DZ2
{
    class Program
    {
        enum Month // Приложение к заданию 2
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
        enum dayWeek // Приложение к заданию 6
        {
            Понедельник =   0b_0000001,
            Вторник =       0b_0000010,
            Среда =         0b_0000100,
            Четверг =       0b_0001000,
            Пятница =       0b_0010000,
            Суббота =       0b_0100000,
            Воскресенье =   0b_1000000
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Практическое задание №2.1\nОпределение среднесуточной температуры."); //1 задание
            Console.Write("Пожалуйста, введите минимальную температуру за сутки: ");
            string a = Console.ReadLine();
            float min = Convert.ToInt32(a);
            Console.Write("Пожалуйста, введите максимальную температуру за сутки: ");
            string b = Console.ReadLine();
            float max = Convert.ToInt32(b);
            float averageTemp = (min + max) / 2;
            Console.WriteLine("Средняя температура равняется: " + averageTemp);
            Console.WriteLine(" ");
           
            Console.WriteLine("Практическое задание №2.2\nОпределение месяца по порядковому номеру."); //2 задание
            Console.Write("Введите порядковый номер месяца: ");
            string i = Console.ReadLine();
            int monthAnswer = Convert.ToInt32(i);
            Month curentMonth = (Month)monthAnswer;
            Console.WriteLine("Данному номеру соответствует месяц: "+curentMonth);
            Console.WriteLine(" ");
            {
                if (averageTemp > 0 && monthAnswer < 3 || monthAnswer == 12) // 5 задание
                {
                    Console.WriteLine("Практическое задание №2.5\nВыполнение условия.");
                    Console.WriteLine("Дождливая зима.");
                    Console.WriteLine(" ");
                }
            }
                
            {
                Console.WriteLine("Практическое задание №2.3\nОпределение четного, нечетного числа."); // 3 задание
                Console.Write("Пожалуйста, введите число: ");
                string n = Console.ReadLine();
                int number = Convert.ToInt32(n);
                int even = number%2;
                if (even == 1)
                {
                    Console.WriteLine("Введеное число является нечетным!");
                }
                else
                {
                    Console.WriteLine("Введеное число является четным!");
                }
            }



            Console.WriteLine("Практическое задание №2.6\nБитовые маски."); // 6 задание
            Console.Write("Пожалуйста, введите день недели: ");
            string day = Console.ReadLine();
            dayWeek dayAnswer = dayWeek.day;
            dayWeek first = (dayWeek)0b_0011110;
            dayWeek second = (dayWeek)0b_1111111;
            bool firstOffice = first == dayAnswer;
            bool secondOffice = second == dayAnswer;
            if (firstOffice & secondOffice)
            {
                Console.WriteLine("Рабочие офисы: 1, 2.");
            }
            else
            {
                Console.WriteLine("Рабочие офисы: 2");
            }
        }
    }
}
