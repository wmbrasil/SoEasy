using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoEasy;

namespace SoEasyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "banana abacaxi morango chocolate";

            string between = text.Between("banana", "chocolate");
        }
    }
}
