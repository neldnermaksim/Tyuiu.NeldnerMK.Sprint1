using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint1.Task4.V1.Lib;

namespace Tyuiu.NeldnerMK.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -1;  

            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);

        }
    }
}
