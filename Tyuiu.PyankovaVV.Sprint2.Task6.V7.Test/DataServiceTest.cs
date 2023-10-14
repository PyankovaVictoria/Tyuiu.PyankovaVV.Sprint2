using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.PyankovaVV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int startYear = 1990;
            string res = ds.FindMonthName(startYear, n);
            string wait = "июнь";
            Assert.AreEqual(wait, res);
        }
    }
}
