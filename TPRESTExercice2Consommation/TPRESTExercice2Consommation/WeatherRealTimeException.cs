using System;
using System.Net;
using System.Runtime.Serialization;

namespace TPRESTExercice2Consommation
{
    [Serializable]
    internal class WeatherRealTimeException : Exception
    {
        private HttpStatusCode statusCode;
        private string reasonPhrase;

        public WeatherRealTimeException()
        {
        }

        public WeatherRealTimeException(string message) : base(message)
        {
        }

        public WeatherRealTimeException(HttpStatusCode statusCode, string reasonPhrase)
            : this("Client received the status '" + statusCode.ToString() + "'")
        {
            this.statusCode = statusCode;
            this.reasonPhrase = reasonPhrase;
        }

        public WeatherRealTimeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeatherRealTimeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}