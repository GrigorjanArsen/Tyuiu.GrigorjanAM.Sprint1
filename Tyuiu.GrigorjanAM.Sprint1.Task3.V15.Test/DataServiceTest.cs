using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 60.0;
            double v2 = 80.0;
            double s = 20.0;
            double t = 4;
            var res = ds.DistanceOverTime(v1, v2, s, t);
            Assert.AreEqual(580, res);

        }
    }
}
