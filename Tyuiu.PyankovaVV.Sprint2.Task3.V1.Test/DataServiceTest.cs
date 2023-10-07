using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint2.Task3.V1.Lib;

namespace Tyuiu.PyankovaVV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            double x = 5;

            var res = ds.Calculate(x);
            Assert.AreEqual(88.697, res);
        }
    }
}
