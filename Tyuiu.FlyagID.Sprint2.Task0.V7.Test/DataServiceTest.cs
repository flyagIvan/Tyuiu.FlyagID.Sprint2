using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint2.Task0.V7.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCompareOperations()
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;

            bool[] expected = { true, false, true, true, true, false };
            bool[] result = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}