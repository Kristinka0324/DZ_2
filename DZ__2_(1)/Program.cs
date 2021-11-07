using System;

namespace DZ__2__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double mintemp, maxtemp;  

            Console.WriteLine("Введите число 1");

            mintemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            maxtemp = double.Parse(Console.ReadLine());

            double result = (mintemp + maxtemp) / 2;

            Console.WriteLine("среднесуточная температура = " + result);

        }
    }
}
