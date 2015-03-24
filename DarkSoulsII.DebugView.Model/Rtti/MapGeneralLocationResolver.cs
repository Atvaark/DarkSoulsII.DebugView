using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Map.Location;
using DarkSoulsII.DebugView.Model.Map.Location.Phantom;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class MapGeneralLocationResolver : AbstractRttiResolver<MapGeneralLocation>
    {
        protected override IPointer<MapGeneralLocation> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            IPointer<MapGeneralLocation> pointer;
            switch (vtable)
            {
                case 0x012C03A0:
                    pointer = pointerFactory.Create<MapGeneralWindLocation>(address, relative, true);
                    break;
                case 0x012C02DC:
                    pointer = pointerFactory.Create<MapGeneralStatueLocation>(address, relative, true);
                    break;
                case 0x012C0244:
                    pointer = pointerFactory.Create<MapGeneralSlideLocation>(address, relative, true);
                    break;
                case 0x012C0194:
                    pointer = pointerFactory.Create<MapGeneralPhantomLocation>(address, relative, true);
                    break;
                case 0x012C0110:
                    pointer = pointerFactory.Create<MapGeneralNavimeshLocation>(address, relative, true);
                    break;
                case 0x012C0040:
                    pointer = pointerFactory.Create<MapGeneralLogicNoEntryLocation>(address, relative, true);
                    break;
                case 0x012BFF78:
                    pointer = pointerFactory.Create<MapGeneralLogicLocation>(address, relative, true);
                    break;
                case 0x012BFEC8:
                    pointer = pointerFactory.Create<MapGeneralLockOffLocation>(address, relative, true);
                    break;
                case 0x012BFE10:
                    pointer = pointerFactory.Create<MapGeneralIntrudeLocation>(address, relative, true);
                    break;
                case 0x012BFD78:
                    pointer = pointerFactory.Create<MapGeneralGeneratorLocation>(address, relative, true);
                    break;
                case 0x012BFCBC:
                    pointer = pointerFactory.Create<MapGeneralEventTriggerLocation>(address, relative, true);
                    break;
                case 0x012BFBF4:
                    pointer = pointerFactory.Create<MapGeneralEventJudgmentLocation>(address, relative, true);
                    break;
                case 0x012BFB2C:
                    pointer = pointerFactory.Create<MapGeneralDamageLocation>(address, relative, true);
                    break;
                case 0x012BFAA8:
                    pointer = pointerFactory.Create<MapGeneralBulletLocation>(address, relative, true);
                    break;
                case 0x012BF9DC:
                    pointer = pointerFactory.Create<MapGeneralBrightLocation>(address, relative, true);
                    break;
                case 0x012BF924:
                    pointer = pointerFactory.Create<MapGeneralBloodMsgLocation>(address, relative, true);
                    break;
                case 0x012BF8BC:
                    pointer = pointerFactory.Create<MapGeneralBloodMsgDisableLocation>(address, relative, true);
                    break;
                case 0x012BF7D8:
                    pointer = pointerFactory.Create<MapGeneralBackreadSafetyLocation>(address, relative, true);
                    break;
                case 0x012D947C:
                    pointer = pointerFactory.Create<MapGeneralAdviceBloodMsgLocation>(address, relative, true);
                    break;
                case 0x012D4A94:
                    pointer = pointerFactory.Create<MapGeneralLocation>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
