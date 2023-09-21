using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.___YOURNAME___.Sprint1.Task1.V13.Lib;

namespace Tyuiu.___YOURNAME___.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0, y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
