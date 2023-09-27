using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint1.Task6.V16.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет! Как дела?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            string wait = "Привет Как дела";
            Assert.AreEqual(wait, res);

        }
    }
}
