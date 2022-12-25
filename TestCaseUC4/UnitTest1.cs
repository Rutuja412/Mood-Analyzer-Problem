using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCaseUC4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
    {
        object expected = new MoodAnalyser();
        object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserAssignment.MoodAnalyser", "MoodAnalyser");
        expected.Equals(obj);
    }
    //UT4.2
    [TestMethod]
    public void Given_MoodAnalyser_ClassName_ImproperShould_Throw_MoodAnalyserException()
    {
        try
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("erMoodAnalyserAssignment.MoodAnalys", "MoodAnalyser");
            expected.Equals(obj);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    //UT4.3
    [TestMethod]
    public void Given_MoodAnalyser_Constructor_Name_Improper_Should_Throw_MoodAnalyserException()
    {
        try
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAssignment.AnalyseMood", "MoodAnaly");
            expected.Equals(obj);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
    }
}
