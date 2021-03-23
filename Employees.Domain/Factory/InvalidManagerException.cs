using System;
using System.Runtime.Serialization;

namespace Employees.Domain.Factory
{
    [Serializable]
    public class InvalidManagerException : Exception
    {
        public InvalidManagerException()
        {
        }

        public InvalidManagerException(string message) : base(message)
        {
        }

        public InvalidManagerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidManagerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}