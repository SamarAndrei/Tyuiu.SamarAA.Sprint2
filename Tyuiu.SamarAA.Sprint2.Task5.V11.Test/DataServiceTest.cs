using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 12;
            int n = 31;
            string wait = "Следующий день: 1.1.2021";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 10;
            int n = 32;
            string wait = "Следующий день: 0.0.0";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);

        }
    }
}
