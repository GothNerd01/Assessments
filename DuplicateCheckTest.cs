using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace AssessmentTest
{
    [TestClass]
    public class DuplicateChecktest
    {
        [TestMethod]
        public void dupicateCheckPositiveCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = "iletap";
            var actualResult = assessment.duplicateCheck("I like eating apples");

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void dupicateCheckNegativeCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = "";
            var actualResult = assessment.duplicateCheck("abcd4");

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
