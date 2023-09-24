using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task4.V27.Lib;

namespace Tyuiu.GrigorjanAM.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 16.0;
            double wait = -0.5;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}
