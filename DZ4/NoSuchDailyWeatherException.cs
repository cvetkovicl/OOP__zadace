using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    class NoSuchDailyWeatherException : Exception
    {
        private DateTime dateTime;
        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(string message) : base(message) { }
        public NoSuchDailyWeatherException(string message, DateTime dateTime) : base(message) {
            this.dateTime = dateTime;
        }
        public NoSuchDailyWeatherException(string message, Exception innerException) : base(message, innerException) { }
        protected NoSuchDailyWeatherException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
