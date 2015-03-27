using System;
using System.Runtime.Serialization;

namespace DarkSoulsII.DebugView.Core.Exceptions
{
    [Serializable]
    public class ProcessNotFoundException : ApplicationException
    {
        public ProcessNotFoundException()
        {
        }

        public ProcessNotFoundException(string message) : base(message)
        {
        }

        public ProcessNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ProcessNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
