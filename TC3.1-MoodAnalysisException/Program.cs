using System;

namespace TC3._1_MoodAnalysisException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer");
            Console.WriteLine("Sad or Happy");

            string input = Console.ReadLine();

            MoodAnalyse analyse = new MoodAnalyse(input);
            Console.WriteLine(analyse.Analyse);
 

        }
    }
}
