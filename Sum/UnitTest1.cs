using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgrammING;

namespace Sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            int sum;           
            sum = Program.SumD(123);
            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void TestCountD()
        {
            int count;
            count = Program.CountD(123);
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void TestMaxD()
        {
            int maxD;
            maxD = Program.MaxD(123);
            Assert.AreEqual(3, maxD);
        }
    }
}
