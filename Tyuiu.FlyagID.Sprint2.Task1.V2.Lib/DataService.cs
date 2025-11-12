using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FlyagID.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a < b);                // True
            result[1] = (c <= b);               // True
            result[2] = (d > c);                // True
            result[3] = (a + c < b + d);        // True
            result[4] = (a == d);               // False
            result[5] = (b > d) && (a < c);     // False

            return result;
        }
    }
}
