using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class FlverModelData : IReadable<FlverModelData>
    {
        public MdlObj Obj { get; set; }
        public MdlMtx Mtx1 { get; set; }
        public MdlMtx Mtx2 { get; set; }
        public MdlDmy Dmy { get; set; }
        public MdlPrim Prim { get; set; }
        public MdlIdxBuf IdxBuf { get; set; }
        public MdlVtxBuf VtxBuf { get; set; }
        public MdlVtxDecl VtxDecl { get; set; }
        public MdlMtx Mtx3 { get; set; }

        public FlverModelData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Obj = pointerFactory.Create<MdlObj>(address + 0x0008, relative, true).Unbox(pointerFactory, reader);
            Mtx1 = pointerFactory.Create<MdlMtx>(address + 0x001C, relative, true).Unbox(pointerFactory, reader);
            Mtx2 = pointerFactory.Create<MdlMtx>(address + 0x0030, relative, true).Unbox(pointerFactory, reader);
            Dmy = pointerFactory.Create<MdlDmy>(address + 0x0044, relative, true).Unbox(pointerFactory, reader);
            Prim = pointerFactory.Create<MdlPrim>(address + 0x0054, relative, true).Unbox(pointerFactory, reader);
            IdxBuf = pointerFactory.Create<MdlIdxBuf>(address + 0x006C, relative, true).Unbox(pointerFactory, reader);
            VtxBuf = pointerFactory.Create<MdlVtxBuf>(address + 0x0098, relative, true).Unbox(pointerFactory, reader);
            VtxDecl = pointerFactory.Create<MdlVtxDecl>(address + 0x00A8, relative, true).Unbox(pointerFactory, reader);
            Mtx3 = pointerFactory.Create<MdlMtx>(address + 0x00CC, relative, true).Unbox(pointerFactory, reader);
            return this;
        }

    }
}