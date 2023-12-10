using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint3.Task3.V15.Lib;

namespace Tyuiu.GorovenkoGV.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "lrmmse mg sermmmrt";
            char item = 'm';

            double res = ds.GetMinCharCount(value, item);

            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
