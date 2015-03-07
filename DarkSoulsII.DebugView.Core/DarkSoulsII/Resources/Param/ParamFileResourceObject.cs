namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param
{
    public class ParamFileResourceObject<T> : FileResourceObject, IReadable<ParamFileResourceObject<T>>
        where T : class, IReadable<T>, new()
    {
        ////public Memory Memory { get; set; }
        public T Param { get; set; }

        public new ParamFileResourceObject<T> Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            bool read = reader.ReadBoolean(address + 0x00A0, relative) == false;
            ////Memory = Pointer<Memory>.Create(address + 0x008C, relative).Unbox(reader);
            Param = GenericPointer.Create(address + 0x008C).Unbox(reader,
                (r, a) => Pointer<T>.Create(r.ReadInt32(a + 0x0008)).Unbox(r));


            return this;
        }
    }
}
