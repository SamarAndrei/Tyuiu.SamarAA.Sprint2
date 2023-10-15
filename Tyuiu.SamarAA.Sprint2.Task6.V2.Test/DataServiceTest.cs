using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint2.Task6.V2.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 3;
            string res = ds.FindMonthSeason(value);
            string wait = "Весна";

            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            int value = 12;
            string res = ds.FindMonthSeason(value);
            string wait = "Зима";

            Assert.AreEqual(wait, res);

        }
    }
}
