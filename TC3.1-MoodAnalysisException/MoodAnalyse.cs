namespace TC3._1_MoodAnalysisException
{
    internal class MoodAnalyse
    {
        private string input;

        public MoodAnalyse(string input)
        {
            this.input = input;
        }

        public bool Analyse { get; internal set; }
        public bool Analyse1 { get; internal set; }
        public bool Analyse2 { get; internal set; }
    }
}