using System;
using System.Runtime.Serialization;

namespace entities {
    [Serializable]
    internal class PhallicNotFoundException : Exception {
        public PhallicNotFoundException() {
        }

        public PhallicNotFoundException(string message) : base(message) {
        }

        public PhallicNotFoundException(string message, Exception innerException) : base(message, innerException) {
        }

        protected PhallicNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}