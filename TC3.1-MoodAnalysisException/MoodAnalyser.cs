using System;
using System.Collections.Generic;
using System.Text;

namespace TC3._1_MoodAnalysisException
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

        public string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}
