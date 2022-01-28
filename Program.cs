using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            double Mintemp, Maxtemp;

            Console.WriteLine("Введите самую низкую температуру");

            Mintemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите самую высокую температуру");

            Maxtemp = double.Parse(Console.ReadLine());
            double result = (Mintemp+Maxtemp)/ 2;
            Console.WriteLine("Средняя температура за день"  + result);


            
        }
    }
}
