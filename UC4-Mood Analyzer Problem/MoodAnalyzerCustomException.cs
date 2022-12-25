using System;
using System.Collections.Generic;
using System.Text;

namespace UC4_Mood_Analyzer_Problem
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_CLASS, NO_SUCH_METHOD,

        }
        private ExceptionType exceptionType;
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
    

    
}
