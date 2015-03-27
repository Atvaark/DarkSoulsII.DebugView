using System;
using System.Runtime.Serialization;

namespace DarkSoulsII.DebugView.Core.Exceptions
{
    [Serializable]
    public class MemoryInaccessibleException : ApplicationException
    {
        public MemoryInaccessibleException()
        {
        }

        public MemoryInaccessibleException(string message) : base(message)
        {
        }

        public MemoryInaccessibleException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MemoryInaccessibleException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
