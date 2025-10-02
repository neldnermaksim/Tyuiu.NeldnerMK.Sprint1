using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint1.Task3.V12.Lib;

namespace Tyuiu.NeldnerMK.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double lengthCathetus1 = 2;
            double lengthCathetus2 = 4;

            var res = ds.TriangleArea(lengthCathetus1, lengthCathetus2);
            Assert.AreEqual(4, res);

        }
    }
}

