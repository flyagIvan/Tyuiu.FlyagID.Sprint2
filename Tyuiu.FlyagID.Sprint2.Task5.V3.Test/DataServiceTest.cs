using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint2.Task5.V3.Lib;

namespace Tyuiu.FlyagID.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            (
            ds.FindDayName(8)
            ));

            Assert.ThrowsException<ArgumentException>(() =>
            (
            ds.FindDayName(0)
            ));
        }
    }
}