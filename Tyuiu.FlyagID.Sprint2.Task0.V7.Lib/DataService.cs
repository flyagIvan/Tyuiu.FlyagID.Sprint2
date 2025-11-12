using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FlyagID.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x != y;        // True
            res[1] = x == y;        // False
            res[2] = x < y;         // True
            res[3] = x <= y;        // True
            res[4] = y > x;         // True
            res[5] = y <= x;        // False

            return res;
        }
    }
}