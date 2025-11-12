using System;
using Tyuiu.FlyagID.Sprint2.Task3.V28.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task3.V28
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               ");
            Console.WriteLine("**");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);



            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**");

            Console.WriteLine("Значение функции = " + res);


            Console.ReadKey();

        }



    }