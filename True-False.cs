using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Chese;
            Chese = int.Parse(Console.ReadLine());
            if  (Chese % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
            Console.ReadLine();
        }
    }
}
