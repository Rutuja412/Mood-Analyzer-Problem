using System;

namespace TC2._1_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer");
            Console.WriteLine("Sad or Happy");

            string input = Console.ReadLine();

            MoodAnalyse analyse = new MoodAnalyse(input);
        }
    }
}
