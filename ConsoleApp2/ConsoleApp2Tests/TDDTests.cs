using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class TDDTests
    {
        TDD tdd = new TDD();

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(10, tdd.Sum(5, 5));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(25, tdd.Multiply(5, 5));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(0, tdd.Divide(5, 5));
        }
    }
}