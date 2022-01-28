using System;

namespace ConsoleApp1
{
    class Program
    {
        static int temperature;
        

        enum Season
       
        {

            Spring,
            Summer,
            Autumn,
            Winter
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время года : ");
            string str = Console.ReadLine();
             
            
            Season seas = (Season)Enum.Parse(typeof(Season), str, ignoreCase: true);
            
            double Mintemp, Maxtemp;

            Console.WriteLine("Введите самую низкую температуру");

            Mintemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите самую высокую температуру");

            Maxtemp = double.Parse(Console.ReadLine());
            double result = (Mintemp + Maxtemp) / 2;


            if (result >= 0 && seas == Season.Winter) 

            {
                Console.WriteLine("Дождливая зима");
            }
               else 
            {
                Console.WriteLine("Bye Bye");
            }


        }


    }
}
