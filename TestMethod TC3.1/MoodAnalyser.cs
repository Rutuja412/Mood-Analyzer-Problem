using TC3._1_MoodAnalysisException;

namespace TestMethod_TC3._1
{
    internal class MoodAnalyser : MoodAnalyserCustomException
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
    }
}