using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, "+name+", сегодня: "+DateTime.Now);
        }
    }
}
