using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.___YOURNAME___.Sprint1.Task3.V19.Lib;

namespace Tyuiu.___YOURNAME___.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.ElephCanMove(4, 7, 5, 8));
        }
    }
}
