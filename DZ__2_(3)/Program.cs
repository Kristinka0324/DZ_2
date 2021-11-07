using System;

namespace DZ__2__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число (четное или не четное ");
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }

        }
    }
}
