namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics
{
    public class DrawDevice : IReadable<DrawDevice>
    {
        public Surface Surface1 { get; set; }
        public Surface Surface2 { get; set; }

        public DrawDevice Read(IReader reader, int address, bool relative = false)
        {
            //IDirect3D9* pIDirect3D9; //0x000C 
            //IDirect3DDevice9* pIDirect3DDevice9; //0x0010 

            Surface1 = Pointer<Surface>.CreateAndUnbox(reader, address + 0x001C, relative);
            Surface2 = Pointer<Surface>.CreateAndUnbox(reader, address + 0x0034, relative);

            return this;
        }
    }
}
