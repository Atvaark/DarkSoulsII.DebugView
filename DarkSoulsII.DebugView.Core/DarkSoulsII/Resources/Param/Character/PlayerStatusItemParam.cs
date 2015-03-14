namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class PlayerStatusItemParam : IReadable<PlayerStatusItemParam>
    {
        public PlayerStatusItemParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
