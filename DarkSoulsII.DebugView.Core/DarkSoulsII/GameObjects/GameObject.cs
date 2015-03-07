namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects
{
    public class GameObject : IReadable<GameObject>
    {
        public GameObject Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
