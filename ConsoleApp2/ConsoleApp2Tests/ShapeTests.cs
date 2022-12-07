using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class ShapeTests
    {
        Shape shapes = new Shape();
        [TestMethod()]
        public void CircumferenceOfCircleTest()
        {
            Assert.AreEqual(50,shapes.CircumferenceOfCircle(7.142));
        }

        [TestMethod()]
        public void AreaOfTriangleTest()
        {
            Assert.AreEqual(731,shapes.AreaOfTriangle(43,34));
        }

        [TestMethod()]
        public void PerimeterOfRectangleTest()
        {
            Assert.AreEqual(40,shapes.PerimeterOfRectangle(5,15));
        }
    }
}