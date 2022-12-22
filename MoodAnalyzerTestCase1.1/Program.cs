using System;

namespace MoodAnalyzerTestCase1._1
{
    public class Program
    {
        public static string Happy_Mood = "Happy Mood";
        public static string Sad_Mood = "Sad Mood";
        public static void Main(string[] args)
        {
            Mood m = new Mood();
            m.MoodAnalyser(Happy_Mood);
            m.MoodAnalyser(Sad_Mood);
        }


    }
}
