﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.___YOURNAME___.Sprint1.Task3.V14.Lib;

namespace Tyuiu.___YOURNAME___.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double number = 13579, wait = 97531, res = dataService.ReverseNumber(number);
            Assert.AreEqual(wait, res);
        }
    }
}
