using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param
{
    public class ParamFileResourceObject<T> : FileResourceObject, IReadable<ParamFileResourceObject<T>>
        where T : class, IReadable<T>, new()
    {
        ////public Memory Memory { get; set; }
        public T Param { get; set; }

        public new ParamFileResourceObject<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            bool read = reader.ReadBoolean(address + 0x00A0, relative) == false;
            var memory = pointerFactory.Create<Memory>(address + 0x008C, relative, true).Unbox(pointerFactory, reader);
            // TODO: Check if this was converted correctly when the pointer factory was added

            int paramAddress = reader.ReadInt32(address + 0x008C, relative);
            Param = pointerFactory
                .Create<T>(reader.ReadInt32(paramAddress + 0x0008), false, true)
                .Unbox(pointerFactory, reader); // TODO: Test 
            return this;
        }
    }
}
