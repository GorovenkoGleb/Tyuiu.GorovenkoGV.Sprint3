using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint3.Task7.V17.Lib;

namespace Tyuiu.GorovenkoGV.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 13.18;
            valueWaitArray[1] = -2.95;
            valueWaitArray[2] = -4.13;
            valueWaitArray[3] = 4.83;
            valueWaitArray[4] = 10.70;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 6.38;
            valueWaitArray[7] = 11.48;
            valueWaitArray[8] = 19.63;
            valueWaitArray[9] = 17.97;
            valueWaitArray[10] = 1.83;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
