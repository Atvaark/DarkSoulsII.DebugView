using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Sign
{
    public class SignSet<T> : SignSetBase, IReadable<SignSet<T>> where T : class, IFixedSize, IReadable<T>, new()
    {

        public SignSet()
        {
            Signs = new List<T>();
        }

        public List<T> Signs { get; set; }


        public new SignSet<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            int arrayAddress = reader.ReadInt32(address + 0x0024, relative);
            Signs = pointerFactory
                .CreateArrayDereferenced<T>(arrayAddress, false, SignCount)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }
    }
}