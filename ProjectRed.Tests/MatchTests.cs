using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProjectRed;

namespace ProjectRed.Tests
{
    class MatchTests
    {
        private Match match;

        [OneTimeSetUp]
        public void Setup()
        {
            match = new Match();
        }
        
        [TestCase(2, 1, "win owner")]
        [TestCase(1, 2, "guest win")]
        [TestCase(2, 2, "draw")]
        public void GetResultPos(int ownerGoals, int guestGoals, string expectedResult)
        {
            Assert.AreEqual(expectedResult, match.GetResult(ownerGoals, guestGoals));
        }

        [Test]
        public void GetResultNeg()
        {
            try
            {
                string actualResult = match.GetResult(-1, -2);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }
    }
}
