using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3._2TC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { try
            {
                // Arrange
                string message = "";
                string expected = "HAPPY";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                //Act
                string mood = moodAnalyse.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
