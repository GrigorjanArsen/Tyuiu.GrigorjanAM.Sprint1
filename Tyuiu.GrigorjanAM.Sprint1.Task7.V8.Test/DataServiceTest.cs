using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task7.V8.Lib;

namespace Tyuiu.GrigorjanAM.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double x = 2.0;
            double y = 3.0;
            
            double wait = -1.384;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(z, wait);
        }
    }
}
