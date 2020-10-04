using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomodoConsoleChallenge;
namespace UnitTestProject1
{
    [TestClass]
    public class CafeTests
    {
        string[] testArray = new string[5];
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(testArray.Length, 5);
        }
    }
}
