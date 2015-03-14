namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class PlayerStatusNormal : IReadable<PlayerStatusNormal>
    {
        public PlayerStatusNormal Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
