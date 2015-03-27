using System;
using System.Runtime.Serialization;

namespace DarkSoulsII.DebugView.Core.Exceptions
{
    [Serializable]
    public class ProcessAccessDeniedException : ApplicationException
    {
        public ProcessAccessDeniedException()
        {
        }

        public ProcessAccessDeniedException(string message) : base(message)
        {
        }

        public ProcessAccessDeniedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ProcessAccessDeniedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
