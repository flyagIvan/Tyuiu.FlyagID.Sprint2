using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint2.Task3.V28.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double res = ds.Calculate(x);
            double wait = 9.69;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.004;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -439.825;
            Assert.AreEqual(wait, res);
        }
    }
}
