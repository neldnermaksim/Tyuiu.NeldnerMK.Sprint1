using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint1.Task7.V28.Lib;

namespace Tyuiu.NeldnerMK.Sprint1.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;

            var res = ds.Calculate(x,y);
            Assert.AreEqual(9.787, res);

        }
    }
}
