using System;
using System.Runtime.Serialization;

namespace entities {
    [Serializable]
    internal class NoEventsFoundException : Exception {
        public NoEventsFoundException() {
        }

        public NoEventsFoundException(string message) : base(message) {
        }

        public NoEventsFoundException(string message, Exception innerException) : base(message, innerException) {
        }

        protected NoEventsFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}