using System;
using System.Collections.Generic;
using System.Text;

namespace TC3._2_MoodAnalyzer
{
    public class MoodAnalyser
    {
        public class MoodAnalyserCustomException : Exception
        {
            public enum ExceptionType
            {
                NULL_MESSAGE, EMPTY_MESSAGE
            }
            public readonly ExceptionType type;
            public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
            {
                this.type = Type;
            }
        }
    }
}
