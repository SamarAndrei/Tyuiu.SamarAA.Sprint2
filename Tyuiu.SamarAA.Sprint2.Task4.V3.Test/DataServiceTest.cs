using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 3;
            var res = ds.Calculate(x, y);
            double wait = 3.667;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 1;
            var res = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, res);

        }
    }
}
