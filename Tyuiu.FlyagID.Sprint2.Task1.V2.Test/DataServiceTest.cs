using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint2.Task1.V2.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestLogicOperations()
        {
            DataService ds = new DataService();
            int a = 135, b = 156, c = 154, d = 174;

            bool[] expected = { true, true, true, true, false, false };
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}