namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class FreeOrthoCameraOperator : OrthoCameraOperator, IReadable<FreeOrthoCameraOperator>
    {
        public new FreeOrthoCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
