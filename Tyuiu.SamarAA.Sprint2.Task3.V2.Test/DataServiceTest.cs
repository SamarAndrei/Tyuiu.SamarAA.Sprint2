using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint2.Task3.V2.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 90;
            double res = ds.Calculate(x);
            double wait = -990.448;
            Assert.AreEqual(wait, res);


        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            double x = -2;
            double res = ds.Calculate(x);
            double wait = -53;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();

            double x = -21;
            double res = ds.Calculate(x);
            double wait = -231;
            Assert.AreEqual(wait, res);
        }
    }
}
