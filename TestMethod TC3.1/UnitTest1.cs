using Microsoft.VisualStudio.TestTools.UnitTesting;
using TC3._1_MoodAnalysisException;

namespace TestMethod_TC3._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void Throw_MoodAnalyserExpection()
            {
                try
                {
                    string message = null;
                    string expected = "HAPPY";
                    MoodAnalyserCustomException moodAnalyse = new MoodAnalyser(message);
                    string mood = moodAnalyse.AnalyseMood();
                    Assert.AreEqual(expected, mood);
                }
                catch (MoodAnalyserCustomException e)
                {
                    Assert.AreEqual("Mood should not be Null", e.Message);
                }
            }

        
    }
}
