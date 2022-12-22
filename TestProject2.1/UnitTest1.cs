using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        private static void GivenHAPPYMoodShouldReturnHAPPY(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
