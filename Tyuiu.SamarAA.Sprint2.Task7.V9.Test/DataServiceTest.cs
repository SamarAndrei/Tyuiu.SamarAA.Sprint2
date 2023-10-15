using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.SamarAA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = Math.PI / 2;
            double y = 0.4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
