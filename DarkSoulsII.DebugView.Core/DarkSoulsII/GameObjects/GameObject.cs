namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects
{
    public class GameObject : IReadable<GameObject>
    {
        public int ReferenceCounter { get; set; }

        public GameObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ReferenceCounter = reader.ReadInt32(address + 0x0004, relative);
            return this;
        }

    }
}
