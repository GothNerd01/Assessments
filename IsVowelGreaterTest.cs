using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssessmentTest
{
    [TestClass]
    public class IsVowelGreaterTest
    {
        [TestMethod]
        public void isVowelGreaterPositiveCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = "greater";
            var actualResult = assessment.countVowels("I eat");

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void isVowelGreaterNegativeCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = "less";
            var actualResult = assessment.duplicateCheck("that dog");

            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void isVowelGreaterNeutralCheck()
        {
            Assessment assessment = new Assessment();

            var expectedResult = "equal";
            var actualResult = assessment.duplicateCheck("that dog");

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
