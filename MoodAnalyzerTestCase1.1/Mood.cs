using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerTestCase1._1
{
    public class Mood
    {
        public string MoodAnalyser(string Mood)
        {
            if (Mood.ToLower().Contains("sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
            }

            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
        }
    }   }
