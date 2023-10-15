using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.PyankovaVV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -4;
            double y = 8;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0.75;
            double y = 0.25;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
