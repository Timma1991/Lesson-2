using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            int a;
            a = int.Parse(Console.ReadLine());
            string b = "";
           
            switch (a)
            {
                case 1:
                    b = "Январь";
                    break;
                case 2:
                    b = "Февраль";
                    break;
                case 3:
                    b = "Март";
                    break;
                case 4:
                    b = "Апрель";
                    break;
                case 5:
                    b = "Май";
                    break;
                case 6:
                    b = "Июнь";
                    break;
                case 7:
                    b = "Июль";
                    break;
                case 8:
                    b = "Август";
                    break;
                case 9:
                    b = "Сентябрь";
                    break;
                case 10:
                    b = "Октябрь";
                    break;
                case 11:
                    b = "Ноябрь";
                    break;
                case 12:
                    b = "Декабрь";
                    break;
                

            }
            Console.WriteLine(b);
        }
    }
}
