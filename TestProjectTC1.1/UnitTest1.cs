using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerTestCase1._1;

namespace TestProjectTC1._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Mood moodm = new Mood();
            string ExpectedResult = "Sad";

            //act
            string ActualResult = moodm.MoodAnalyser("sad");

            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
