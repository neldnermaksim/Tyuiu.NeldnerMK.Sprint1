using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint1.Task2.V22.Lib;

namespace Tyuiu.NeldnerMK.Sprint1.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 4;
            int valueThree = 6;

            var res = ds.CalculateAVGValue(value, valueTwo, valueThree);
            Assert.AreEqual(4, res);

        }
    }
}
