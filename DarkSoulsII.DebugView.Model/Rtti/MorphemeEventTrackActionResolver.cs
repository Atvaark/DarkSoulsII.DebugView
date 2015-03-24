using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class MorphemeEventTrackActionResolver : AbstractRttiResolver<MorphemeEventTrackAction>
    {
        protected override IPointer<MorphemeEventTrackAction> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            IPointer<MorphemeEventTrackAction> pointer;
            switch (vtable)
            {
                case 0x012E0088:
                    pointer = pointerFactory.Create<MorphemeEventTrackAction>(address, relative, true);
                    break;

                case 0x012D1AD8:
                    pointer = pointerFactory.Create<ChrEventTrackActionUpperBody>(address, relative, true);
                    break;

                case 0x012D1ACC:
                    pointer = pointerFactory.Create<ChrEventTrackActionTimeAct>(address, relative, true);
                    break;

                case 0x012D1AC0:
                    pointer = pointerFactory.Create<ChrEventTrackActionStateControl>(address, relative, true);
                    break;

                case 0x012D1AB4:
                    pointer = pointerFactory.Create<ChrEventTrackActionRope>(address, relative, true);
                    break;

                case 0x012D1AA8:
                    pointer = pointerFactory.Create<ChrEventTrackActionMagic>(address, relative, true);
                    break;

                case 0x012BBC48:
                    pointer = pointerFactory.Create<ChrEventTrackActionItem>(address, relative, true);
                    break;

                case 0x012D1A9C:
                    pointer = pointerFactory.Create<ChrEventTrackActionIk>(address, relative, true);
                    break;

                case 0x012D1A90:
                    pointer = pointerFactory.Create<ChrEventTrackActionHit>(address, relative, true);
                    break;

                case 0x012D1A84:
                    pointer = pointerFactory.Create<ChrEventTrackActionGuardSequence>(address, relative, true);
                    break;

                case 0x012D1A78:
                    pointer = pointerFactory.Create<ChrEventTrackActionGuard>(address, relative, true);
                    break;

                case 0x012D1A6C:
                    pointer = pointerFactory.Create<ChrEventTrackActionGravity>(address, relative, true);
                    break;

                case 0x012D1A60:
                    pointer = pointerFactory.Create<ChrEventTrackActionFootEffect>(address, relative, true);
                    break;

                case 0x012D1A54:
                    pointer = pointerFactory.Create<ChrEventTrackActionFalling>(address, relative, true);
                    break;

                case 0x012BBC3C:
                    pointer = pointerFactory.Create<ChrEventTrackActionEventAction>(address, relative, true);
                    break;

                case 0x012D1A48:
                    pointer = pointerFactory.Create<ChrEventTrackActionDoor>(address, relative, true);
                    break;

                case 0x012D1A3C:
                    pointer = pointerFactory.Create<ChrEventTrackActionDamage>(address, relative, true);
                    break;

                case 0x012BBC30:
                    pointer = pointerFactory.Create<ChrEventTrackActionBossExtraMotion>(address, relative, true);
                    break;

                case 0x012BBC20:
                    pointer = pointerFactory.Create<ChrEventTrackActionBossDie>(address, relative, true);
                    break;

                case 0x012D1A30:
                    pointer = pointerFactory.Create<ChrEventTrackActionBossDamage>(address, relative, true);
                    break;

                case 0x012BBC14:
                    pointer = pointerFactory.Create<ChrEventTrackActionAttackStagger>(address, relative, true);
                    break;

                case 0x012D1A24:
                    pointer = pointerFactory.Create<ChrEventTrackActionAttack>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}