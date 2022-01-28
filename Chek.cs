using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameOOO = "ООО Рога и капыта";
            string Welcome = "Добро пожаловать";
            string Kpp = "77544573";
            string Inn = "32456234";
            string a = "КПП";
            string b = "ИНН";
            int c = 123456;
            double prise = 38.45;
            double prise2 = 66.27;
            DateTime dt = DateTime.Today;
            Console.WriteLine($"|--------{NameOOO}--------|");
            Console.WriteLine($"|--------{Welcome}-------- |");
            Console.WriteLine($"|{a}{Kpp}         {b}{Inn}  |");
            Console.WriteLine($"|{dt}-------- {c}|");
            Console.WriteLine($"|Системный администратор-   {c}|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|Сыр Российский     = {prise}       |");
            Console.WriteLine($"|Пиво Bud           = {prise2}       |"); 
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");
            Console.WriteLine($"|---------------------------------|");








            Console.WriteLine($"|Итого               {(prise + prise2)}       |");


        }
    }
}
