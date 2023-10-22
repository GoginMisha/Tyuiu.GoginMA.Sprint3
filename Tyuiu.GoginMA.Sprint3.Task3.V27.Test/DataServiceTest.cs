using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GoginMA.Sprint3.Task3.V27.Lib;

namespace Tyuiu.GoginMA.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";
            int res = ds.ConvertStringToInt(value);
            int wait = 567;
            Assert.AreEqual(wait, res);
        }
    }
}