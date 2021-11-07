using System;

namespace DZ__2__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("зима");
                    Console.WriteLine("Введите температуру");
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }

                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("осень");
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;

            }
        }
    }
}
