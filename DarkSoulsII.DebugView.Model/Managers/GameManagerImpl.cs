using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.App.Sound;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Model.Managers.Ai;
using DarkSoulsII.DebugView.Model.Managers.App;
using DarkSoulsII.DebugView.Model.Managers.Bullet;
using DarkSoulsII.DebugView.Model.Managers.Character;
using DarkSoulsII.DebugView.Model.Managers.Demo;
using DarkSoulsII.DebugView.Model.Managers.Event;
using DarkSoulsII.DebugView.Model.Managers.Input;
using DarkSoulsII.DebugView.Model.Managers.Map;
using DarkSoulsII.DebugView.Model.Managers.Sign;
using DarkSoulsII.DebugView.Model.Managers.StateAct;
using DarkSoulsII.DebugView.Model.Savegame;

namespace DarkSoulsII.DebugView.Model.Managers
{
    public class GameManagerImpl : GameManager, IReadable<GameManagerImpl>
    {
        public CharacterManager CharacterManager { get; set; }
        public CameraManager CameraManager { get; set; }
        public AiManager AiManager { get; set; }
        public AppResourceManager ResourceManager { get; set; }
        public MapManager MapManager { get; set; }
        public EnemyGeneratorManager EnemyGeneratorManager { get; set; }
        public TargetManager TargetManager { get; set; }
        public PadOwnershipManager PadOwnershipManager { get; set; }
        public BulletManager BulletManager { get; set; }
        public EventManager EventManager { get; set; }
        public FaceGenManager FaceGenManager { get; set; }
        public RumbleManager RumbleManager { get; set; }
        public SignManager SignManager { get; set; }
        public StateActManager StateActManager { get; set; }
        public GameDataManager GameDataManager { get; set; }
        public PlayerCtrl PlayerControl { get; set; }
        public SaveLoadSystem SaveLoadSystem { get; set; }
        public int Tick { get; set; }
        public AppDecalManager DecalManager { get; set; }
        public AppTrophyManager AppTrophyManager { get; set; }
        public DemoManager DemoManager { get; set; }
        public KatanaSfxSystem SfxSystem { get; set; }
        public GameManagerState ManagerState { get; set; }

        public new GameManagerImpl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);

            CharacterManager = pointerFactory.Create<CharacterManager>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            CameraManager = pointerFactory.Create<CameraManager>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            AiManager = pointerFactory.Create<AiManager>(address + 0x0020, relative).Unbox(pointerFactory, reader);
            ResourceManager = pointerFactory.Create<AppResourceManager>(address + 0x0024, relative).Unbox(pointerFactory, reader);
            MapManager = pointerFactory.Create<MapManager>(address + 0x0028, relative).Unbox(pointerFactory, reader);
            EnemyGeneratorManager = pointerFactory.Create<EnemyGeneratorManager>(address + 0x002C, relative).Unbox(pointerFactory, reader);
            TargetManager = pointerFactory.Create<TargetManager>(address + 0x0030, relative).Unbox(pointerFactory, reader);
            PadOwnershipManager = pointerFactory.Create<PadOwnershipManager>(address + 0x0034, relative).Unbox(pointerFactory, reader);
            BulletManager = pointerFactory.Create<BulletManager>(address + 0x003C, relative).Unbox(pointerFactory, reader);
            EventManager = pointerFactory.Create<EventManager>(address + 0x0044, relative).Unbox(pointerFactory, reader);
            FaceGenManager = pointerFactory.Create<FaceGenManager>(address + 0x004C, relative).Unbox(pointerFactory, reader);
            RumbleManager = pointerFactory.Create<RumbleManager>(address + 0x0050, relative).Unbox(pointerFactory, reader);
            SignManager = pointerFactory.Create<SignManager>(address + 0x0054, relative).Unbox(pointerFactory, reader);
            StateActManager = pointerFactory.Create<StateActManager>(address + 0x005C, relative).Unbox(pointerFactory, reader);
            GameDataManager = pointerFactory.Create<GameDataManager>(address + 0x0060, relative).Unbox(pointerFactory, reader);
            PlayerControl = pointerFactory.Create<PlayerCtrl>(address + 0x0074, relative).Unbox(pointerFactory, reader);
            SaveLoadSystem = pointerFactory.Create<SaveLoadSystem>(address + 0x0068, relative).Unbox(pointerFactory, reader);
            Tick = reader.ReadInt32(address + 0x00A4, relative);
            DecalManager = pointerFactory.Create<AppDecalManager>(address + 0x0648, relative).Unbox(pointerFactory, reader);
            AppTrophyManager = pointerFactory.Create<AppTrophyManager>(address + 0x0634, relative).Unbox(pointerFactory, reader);
            DemoManager = pointerFactory.Create<DemoManager>(address + 0x065C, relative).Unbox(pointerFactory, reader);
            SfxSystem = pointerFactory.Create<KatanaSfxSystem>(address + 0x0460, relative).Unbox(pointerFactory, reader);

            ManagerState = (GameManagerState) reader.ReadInt32(address + 0x0DEC, relative);
            return this;
        }

    }
}
