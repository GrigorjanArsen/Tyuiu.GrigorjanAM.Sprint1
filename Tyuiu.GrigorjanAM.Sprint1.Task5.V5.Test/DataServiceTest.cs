using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task5.V5.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double result = ds.Calculate(x);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
