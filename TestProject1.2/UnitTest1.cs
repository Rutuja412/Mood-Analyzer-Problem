using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Mood moodm = new Mood();
            string ExpectedResult = "Happy";

            //act
            string ActualResult = moodm.MoodAnalyser("Happy");

            //assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
