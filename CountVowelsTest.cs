using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace AssessmentTest
{
    [TestClass]
    public class CountVowelsTest
    {
        [TestMethod]
        public void countVowelsPositiveCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = 3;
            var actualResult = assessment.countVowels("I like eating apples");

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void countVowelsNegativeCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = 0;
            var actualResult = assessment.duplicateCheck("jkl kkjh");

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
