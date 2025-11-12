using System;
using Tyuiu.FlyagID.Sprint2.Task7.V3.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }

            Console.ReadKey();
        }
    }
}