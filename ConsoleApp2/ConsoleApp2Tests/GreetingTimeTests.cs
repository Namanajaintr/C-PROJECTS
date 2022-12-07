using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class GreetingTimeTests
    {
        GreetingTime greets = new GreetingTime();

        [TestMethod()]
        public void GreetTest() {
            Assert.AreEqual("Good Morning",greets.Greet());
        }

        [TestMethod()]
        public void GreetTest2() {
            Assert.AreEqual("Good Afternoon", greets.Greet());
        }
    }
}