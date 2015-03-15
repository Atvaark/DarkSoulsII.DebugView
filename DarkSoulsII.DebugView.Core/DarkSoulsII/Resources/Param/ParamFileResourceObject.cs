namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param
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
            var Memory = pointerFactory.Create<Memory>(address + 0x008C, relative, true).Unbox(pointerFactory, reader);
			// TODO: Check if this was converted correctly when the pointer factory was added
                Param = GenericPointer.Create(address + 0x008C).Unbox(reader,
                (r, a) => pointerFactory.Create<T>(r.ReadInt32(a + 0x0008), false, true).Unbox(pointerFactory, r));
            return this;
        }
    }
}
