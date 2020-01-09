using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProjectRed;

namespace ProjectRed.Tests
{
    class TriangleTests
    {
        private Triangle triangle;

        [OneTimeSetUp]
        public void Setup()
        {
            triangle = new Triangle();
        }

        [Test]
        public void PosSquareTest()
        {
            double actualResult = triangle.Square(5, 2);
            double expectedResult = 5;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void NegSquareTest()
        {
            try
            {
                double actualResult = triangle.Square(-2, -3);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void PosHypoTest()
        {
            double actualResult = triangle.Hypotenuse(3, 4);
            double expectedResult = 5;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void NegHypoTest()
        {
            try 
            {
                double actualResult = triangle.Hypotenuse(-2, 9);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }
    }
}
