using System;
using Tyuiu.FlyagID.Sprint2.Task0.V7.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("* Спринт #2                                               ");
            Console.WriteLine(" Тема: Операции сравнения                                 ");
            Console.WriteLine(" Задание #0                                               ");
            Console.WriteLine(" Вариант #7                                               ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine("");
            Console.WriteLine(" УСЛОВИЕ:");
            Console.WriteLine(" Написать программу, которая возвращает логическую последовательность");
            Console.WriteLine(" (True, False, True, True, True, False), при x = 103, y = 475");
            Console.WriteLine("-----------------------------------------------------------");

            int x = 103;
            int y = 475;

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Элемент [{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}
