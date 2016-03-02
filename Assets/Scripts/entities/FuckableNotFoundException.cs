using System;
using System.Runtime.Serialization;

namespace entities {
    [Serializable]
    internal class FuckableNotFoundException : Exception {
        public FuckableNotFoundException() {
        }

        public FuckableNotFoundException(string message) : base(message) {
        }

        public FuckableNotFoundException(string message, Exception innerException) : base(message, innerException) {
        }

        protected FuckableNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}