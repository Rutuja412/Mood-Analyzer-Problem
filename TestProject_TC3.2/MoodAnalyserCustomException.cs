﻿using System;
using System.Runtime.Serialization;

namespace TestProject_TC3._2
{
    [Serializable]
    internal class MoodAnalyserCustomException : Exception
    {
        public MoodAnalyserCustomException()
        {
        }

        public MoodAnalyserCustomException(string message) : base(message)
        {
        }

        public MoodAnalyserCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}