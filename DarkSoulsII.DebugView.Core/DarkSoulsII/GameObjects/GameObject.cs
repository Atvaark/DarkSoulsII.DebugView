namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects
{
    public class GameObject : IReadable<GameObject>
    {
        public GameObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
