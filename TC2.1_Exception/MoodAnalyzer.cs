using System;
using System.Collections.Generic;
using System.Text;

namespace TC2._1_Exception
{
    internal class MoodAnalyzer
    {
        private string mood;
        public MoodAnalyzer(string message)
        {
            this.mood = mood;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.mood.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }  }