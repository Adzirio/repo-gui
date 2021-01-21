using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическое задание №2.3\nОпределение четного, нечетного числа.");
            int n = Console.Read();
            if (n % 2 == 1)
            {
                Console.WriteLine("Введеное число является нечетным!");
            }
            else
            {
                Console.WriteLine("Введеное число является четным!");
            }
        }
    }
}
