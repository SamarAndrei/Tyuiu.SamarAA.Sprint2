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
            int g = 1;
            int m = 2;
            int n = 3;
            string wait = "6";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);

        }
    }
}
