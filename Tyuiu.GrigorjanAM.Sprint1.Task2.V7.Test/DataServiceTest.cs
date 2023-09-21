using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task2.V7.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(12.56, res);
        }
    }
}
