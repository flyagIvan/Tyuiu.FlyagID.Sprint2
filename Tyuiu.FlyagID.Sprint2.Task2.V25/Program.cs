using System;
using Tyuiu.FlyagID.Sprint2.Task2.V25.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Фляг И.Д. | ИСПб-25-1";
            Console.WriteLine("* Спринт #2                                               ");
            Console.WriteLine(" Тема: Операции сравнения и логические операции            ");
            Console.WriteLine(" Задание #2                                               ");
            Console.WriteLine(" Вариант #25                                              ");
            Console.WriteLine(" Выполнил: Фляг И.Д. | ИСПб-25-1                          ");
            Console.WriteLine();
            Console.WriteLine(" УСЛОВИЕ:");
            Console.WriteLine(" Написать программу, которая возвращает логическую последовательность");
            Console.WriteLine(" (True, True, True, True, False, False), при a = 135, b = 156, c = 154, d = 174");
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res == true) { Console.WriteLine("Точка находится в заштрихованной области."); }
            else { Console.WriteLine("Точка не находится в заштрихованной области."); }

            
            Console.ReadKey();
        }
    }
}