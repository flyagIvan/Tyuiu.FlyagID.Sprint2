using System;
using Tyuiu.FlyagID.Sprint2.Task1.V2.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("* Спринт #2                                               ");
            Console.WriteLine(" Тема: Операции сравнения и логические операции            ");
            Console.WriteLine(" Задание #1                                               ");
            Console.WriteLine(" Вариант #2                                               ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine();
            Console.WriteLine(" УСЛОВИЕ:");
            Console.WriteLine(" Написать программу, которая возвращает логическую последовательность");
            Console.WriteLine(" (True, True, True, True, False, False), при a = 135, b = 156, c = 154, d = 174");
            Console.WriteLine("-----------------------------------------------------------");

            int a = 135, b = 156, c = 154, d = 174;

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Элемент [{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}