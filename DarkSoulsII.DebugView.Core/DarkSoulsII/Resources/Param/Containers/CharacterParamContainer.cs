using DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Containers
{
    public class CharacterParamContainer : IReadable<CharacterParamContainer>
    {
        public ParamFileResourceObjectForRegulation<ChrParam> ChrParam1 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrCommonParam> ChrCommonParam1 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrMoveParam> ChrMoveParam1 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrEquipWeaponParam> ChrEquipWeaponParam1 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrParam> ChrParam2 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrCommonParam> ChrCommonParam2 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrMoveParam> ChrMoveParam2 { get; set; }
        public ParamFileResourceObjectForRegulation<ChrEquipWeaponParam> ChrEquipWeaponParam2 { get; set; }
        public ParamFileResourceObjectForRegulation<PlayerCommonParam> PlayerCommonParam { get; set; }
        public ParamFileResourceObjectForRegulation<BehaviorParam> BehaviorParam1 { get; set; }
        public ParamFileResourceObjectForRegulation<BehaviorParam> BehaviorParam2 { get; set; }
        public ParamFileResourceObjectForRegulation<BehaviorParam> BehaviorParam3 { get; set; }
        public ParamFileResourceObjectForRegulation<ComboBehaviorParam> ComboBehaviorParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrColorParam> ChrColorParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrCullingParam> ChrCullingParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrEquipLoadParam> ChrEquipLoadParam { get; set; }
        public ParamFileResourceObjectForRegulation<FallingParam> FallingParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponParam> WeaponParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponActionCategoryParam> WeaponActionCategoryParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponAttackMotionParam> WeaponAttackMotionParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponTypeParam> WeaponTypeParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponStaminaCostParam> WeaponStaminaCostParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponReinforceParam> WeaponReinforceParam { get; set; }
        public ParamFileResourceObjectForRegulation<WeaponStatsAffectParam> WeaponStatsAffectParam { get; set; }
        public ParamFileResourceObjectForRegulation<DualWieldPermissionParam> DualWieldPermissionParam { get; set; }
        public ParamFileResourceObjectForRegulation<ArmorParam> ArmorParam { get; set; }
        public ParamFileResourceObjectForRegulation<ArmorReinforceParam> ArmorReinforceParam { get; set; }
        public ParamFileResourceObjectForRegulation<ArmorHandsUpFParam> ArmorHandsUpFParam { get; set; }
        public ParamFileResourceObjectForRegulation<EquipmentInterfereParam> EquipmentInterfereParam { get; set; }

        public ParamFileResourceObjectForRegulation<EquipmentCullingTargetParam> EquipmentCullingTargetParam { get; set;
        }

        public ParamFileResourceObjectForRegulation<CustomAttrSpecParam> CustomAttrSpecParam { get; set; }
        public ParamFileResourceObjectForRegulation<CustomAttrCostParam> CustomAttrCostParam { get; set; }
        public ParamFileResourceObjectForRegulation<ReinforceCostParam> ReinforceCostParam { get; set; }
        public ParamFileResourceObjectForRegulation<ArrowParam> ArrowParam { get; set; }
        public ParamFileResourceObjectForRegulation<RingParam> RingParam { get; set; }
        public ParamFileResourceObjectForRegulation<SpellParam> SpellParam { get; set; }
        public ParamFileResourceObjectForRegulation<SpellSoulConsumeParam> SpellSoulConsumeParam { get; set; }
        public ParamFileResourceObjectForRegulation<FootEffectSfxParam> FootEffectSfxParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrGrowthParam> ChrGrowthParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrLevelUpSoulsParam> ChrLevelUpSoulsParam { get; set; }
        public ParamFileResourceObjectForRegulation<RelatePhysStatToLevelStat> RelatePhysStatToLevelStat { get; set; }
        public ParamFileResourceObjectForRegulation<PhysStatsPerLevelStatParam> PhysStatsPerLevelStatParam { get; set; }
        public ParamFileResourceObjectForRegulation<MenuStatsParam> MenuStatsParam { get; set; }
        public ParamFileResourceObjectForRegulation<HollowLevelStatsParam> HollowLevelStatsParam { get; set; }
        public ParamFileResourceObjectForRegulation<LackOfStatsParam> LackOfStatsParam { get; set; }
        public ParamFileResourceObjectForRegulation<NpcGenerateParam> NpcGenerateParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrEditParamBodyPreset> ChrEditParamBodyPreset { get; set; }
        public ParamFileResourceObjectForRegulation<MaterialParam> MaterialParam { get; set; }
        public ParamFileResourceObjectForRegulation<GroundMaterialParam> GroundMaterialParam { get; set; }
        public ParamFileResourceObjectForRegulation<LockOnParam> LockOnParam { get; set; }
        public ParamFileResourceObjectForRegulation<LockTargetParam> LockTargetParam { get; set; }
        public ParamFileResourceObjectForRegulation<LockOnCameraOffsetParam> LockOnCameraOffsetParam { get; set; }
        public ParamFileResourceObjectForRegulation<GuardLevelMotionParam> GuardLevelMotionParam { get; set; }
        public ParamFileResourceObjectForRegulation<BossParam> BossParam { get; set; }
        public ParamFileResourceObjectForRegulation<BossPartsParam> BossPartsParam { get; set; }
        public ParamFileResourceObjectForRegulation<BossPartsModelParam> BossPartsModelParam { get; set; }
        public ParamFileResourceObjectForRegulation<BossEnemyGenerateParam> BossEnemyGenerateParam { get; set; }
        public ParamFileResourceObjectForRegulation<GrabParam> GrabParam { get; set; }
        public ParamFileResourceObjectForRegulation<DeadTypeParam> DeadTypeParam { get; set; }
        public ParamFileResourceObjectForRegulation<TorchCtrlParam> TorchCtrlParam { get; set; }
        public ParamFileResourceObjectForRegulation<TorchOffCtrlParam> TorchOffCtrlParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrWetParam> ChrWetParam { get; set; }
        public ParamFileResourceObjectForRegulation<HitBackMatrixParam> HitBackMatrixParam { get; set; }
        public ParamFileResourceObjectForRegulation<HitBackParam> HitBackParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrFullbodySfxParam> ChrFullbodySfxParam { get; set; }
        public ParamFileResourceObjectForRegulation<EnemyAttackMoveParam> EnemyAttackMoveParam { get; set; }
        public ParamFileResourceObjectForRegulation<PlayerStatusNormal> PlayerStatusNormal { get; set; }
        public ParamFileResourceObjectForRegulation<PlayerStatusItemParam> PlayerStatusItemParam { get; set; }
        public ParamFileResourceObjectForRegulation<NpcPlayerStatusParam> NpcPlayerStatusParam { get; set; }
        public ParamFileResourceObjectForRegulation<NpcPlayerSkinParam> NpcPlayerSkinParam { get; set; }
        public ParamFileResourceObjectForRegulation<CriminalAndDeceasedParam> CriminalAndDeceasedParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrPointWindParam> ChrPointWindParam { get; set; }
        public ParamFileResourceObjectForRegulation<PlayerLightParam> PlayerLightParam { get; set; }
        public ParamFileResourceObjectForRegulation<VowParam> VowParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrNetworkPhantomParam> ChrNetworkPhantomParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrNetPhantomSoulRateParam> ChrNetPhantomSoulRateParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrModelParam> ChrModelParam { get; set; }
        public ParamFileResourceObjectForRegulation<EnemyShotSfxParam> EnemyShotSfxParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrRoundDamageParam> ChrRoundDamageParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrRoundDropSoulParam> ChrRoundDropSoulParam { get; set; }
        public ParamFileResourceObjectForRegulation<ChrMultiplayParam> ChrMultiplayParam { get; set; }
        public ParamFileResourceObjectForRegulation<FootEffectWaterSfxParam> FootEffectWaterSfxParam { get; set; }

        public CharacterParamContainer Read(IReader reader, int address, bool relative = false)
        {
            ChrParam1 = Pointer<ParamFileResourceObjectForRegulation<ChrParam>>.CreateAndUnbox(reader, address + 0x000,
                relative);
            ChrCommonParam1 = Pointer<ParamFileResourceObjectForRegulation<ChrCommonParam>>.CreateAndUnbox(reader,
                address + 0x008, relative);
            ChrMoveParam1 = Pointer<ParamFileResourceObjectForRegulation<ChrMoveParam>>.CreateAndUnbox(reader,
                address + 0x0010, relative);
            ChrEquipWeaponParam1 =
                Pointer<ParamFileResourceObjectForRegulation<ChrEquipWeaponParam>>.CreateAndUnbox(reader,
                    address + 0x0018, relative);
            ChrParam2 = Pointer<ParamFileResourceObjectForRegulation<ChrParam>>.CreateAndUnbox(reader, address + 0x0020,
                relative);
            ChrCommonParam2 = Pointer<ParamFileResourceObjectForRegulation<ChrCommonParam>>.CreateAndUnbox(reader,
                address + 0x0028, relative);
            ChrMoveParam2 = Pointer<ParamFileResourceObjectForRegulation<ChrMoveParam>>.CreateAndUnbox(reader,
                address + 0x0030, relative);
            ChrEquipWeaponParam2 =
                Pointer<ParamFileResourceObjectForRegulation<ChrEquipWeaponParam>>.CreateAndUnbox(reader,
                    address + 0x0038, relative);
            PlayerCommonParam = Pointer<ParamFileResourceObjectForRegulation<PlayerCommonParam>>.CreateAndUnbox(reader,
                address + 0x0040, relative);
            BehaviorParam1 = Pointer<ParamFileResourceObjectForRegulation<BehaviorParam>>.CreateAndUnbox(reader,
                address + 0x0048, relative);
            BehaviorParam2 = Pointer<ParamFileResourceObjectForRegulation<BehaviorParam>>.CreateAndUnbox(reader,
                address + 0x0050, relative);
            BehaviorParam3 = Pointer<ParamFileResourceObjectForRegulation<BehaviorParam>>.CreateAndUnbox(reader,
                address + 0x0058, relative);
            ComboBehaviorParam = Pointer<ParamFileResourceObjectForRegulation<ComboBehaviorParam>>.CreateAndUnbox(
                reader, address + 0x0060, relative);
            ChrColorParam = Pointer<ParamFileResourceObjectForRegulation<ChrColorParam>>.CreateAndUnbox(reader,
                address + 0x0068, relative);
            ChrCullingParam = Pointer<ParamFileResourceObjectForRegulation<ChrCullingParam>>.CreateAndUnbox(reader,
                address + 0x0070, relative);
            ChrEquipLoadParam = Pointer<ParamFileResourceObjectForRegulation<ChrEquipLoadParam>>.CreateAndUnbox(reader,
                address + 0x0078, relative);
            FallingParam = Pointer<ParamFileResourceObjectForRegulation<FallingParam>>.CreateAndUnbox(reader,
                address + 0x0080, relative);
            WeaponParam = Pointer<ParamFileResourceObjectForRegulation<WeaponParam>>.CreateAndUnbox(reader,
                address + 0x0088, relative);
            WeaponActionCategoryParam =
                Pointer<ParamFileResourceObjectForRegulation<WeaponActionCategoryParam>>.CreateAndUnbox(reader,
                    address + 0x0090, relative);
            WeaponAttackMotionParam =
                Pointer<ParamFileResourceObjectForRegulation<WeaponAttackMotionParam>>.CreateAndUnbox(reader,
                    address + 0x0098, relative);
            WeaponTypeParam = Pointer<ParamFileResourceObjectForRegulation<WeaponTypeParam>>.CreateAndUnbox(reader,
                address + 0x00A0, relative);
            WeaponStaminaCostParam =
                Pointer<ParamFileResourceObjectForRegulation<WeaponStaminaCostParam>>.CreateAndUnbox(reader,
                    address + 0x00A8, relative);
            WeaponReinforceParam =
                Pointer<ParamFileResourceObjectForRegulation<WeaponReinforceParam>>.CreateAndUnbox(reader,
                    address + 0x00B0, relative);
            WeaponStatsAffectParam =
                Pointer<ParamFileResourceObjectForRegulation<WeaponStatsAffectParam>>.CreateAndUnbox(reader,
                    address + 0x00B8, relative);
            DualWieldPermissionParam =
                Pointer<ParamFileResourceObjectForRegulation<DualWieldPermissionParam>>.CreateAndUnbox(reader,
                    address + 0x00C0, relative);
            ArmorParam = Pointer<ParamFileResourceObjectForRegulation<ArmorParam>>.CreateAndUnbox(reader,
                address + 0x00C8, relative);
            ArmorReinforceParam =
                Pointer<ParamFileResourceObjectForRegulation<ArmorReinforceParam>>.CreateAndUnbox(reader,
                    address + 0x00D0, relative);
            ArmorHandsUpFParam = Pointer<ParamFileResourceObjectForRegulation<ArmorHandsUpFParam>>.CreateAndUnbox(
                reader, address + 0x00D8, relative);
            EquipmentInterfereParam =
                Pointer<ParamFileResourceObjectForRegulation<EquipmentInterfereParam>>.CreateAndUnbox(reader,
                    address + 0x00E0, relative);
            EquipmentCullingTargetParam =
                Pointer<ParamFileResourceObjectForRegulation<EquipmentCullingTargetParam>>.CreateAndUnbox(reader,
                    address + 0x00E8, relative);
            CustomAttrSpecParam =
                Pointer<ParamFileResourceObjectForRegulation<CustomAttrSpecParam>>.CreateAndUnbox(reader,
                    address + 0x00F0, relative);
            CustomAttrCostParam =
                Pointer<ParamFileResourceObjectForRegulation<CustomAttrCostParam>>.CreateAndUnbox(reader,
                    address + 0x00F8, relative);
            ReinforceCostParam = Pointer<ParamFileResourceObjectForRegulation<ReinforceCostParam>>.CreateAndUnbox(
                reader, address + 0x00100, relative);
            ArrowParam = Pointer<ParamFileResourceObjectForRegulation<ArrowParam>>.CreateAndUnbox(reader,
                address + 0x00108, relative);
            RingParam = Pointer<ParamFileResourceObjectForRegulation<RingParam>>.CreateAndUnbox(reader,
                address + 0x00110, relative);
            SpellParam = Pointer<ParamFileResourceObjectForRegulation<SpellParam>>.CreateAndUnbox(reader,
                address + 0x00118, relative);
            SpellSoulConsumeParam =
                Pointer<ParamFileResourceObjectForRegulation<SpellSoulConsumeParam>>.CreateAndUnbox(reader,
                    address + 0x00120, relative);
            FootEffectSfxParam = Pointer<ParamFileResourceObjectForRegulation<FootEffectSfxParam>>.CreateAndUnbox(
                reader, address + 0x00128, relative);
            ChrGrowthParam = Pointer<ParamFileResourceObjectForRegulation<ChrGrowthParam>>.CreateAndUnbox(reader,
                address + 0x00130, relative);
            ChrLevelUpSoulsParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrLevelUpSoulsParam>>.CreateAndUnbox(reader,
                    address + 0x00138, relative);
            RelatePhysStatToLevelStat =
                Pointer<ParamFileResourceObjectForRegulation<RelatePhysStatToLevelStat>>.CreateAndUnbox(reader,
                    address + 0x00140, relative);
            PhysStatsPerLevelStatParam =
                Pointer<ParamFileResourceObjectForRegulation<PhysStatsPerLevelStatParam>>.CreateAndUnbox(reader,
                    address + 0x00148, relative);
            MenuStatsParam = Pointer<ParamFileResourceObjectForRegulation<MenuStatsParam>>.CreateAndUnbox(reader,
                address + 0x00150, relative);
            HollowLevelStatsParam =
                Pointer<ParamFileResourceObjectForRegulation<HollowLevelStatsParam>>.CreateAndUnbox(reader,
                    address + 0x00158, relative);
            LackOfStatsParam = Pointer<ParamFileResourceObjectForRegulation<LackOfStatsParam>>.CreateAndUnbox(reader,
                address + 0x00160, relative);
            NpcGenerateParam = Pointer<ParamFileResourceObjectForRegulation<NpcGenerateParam>>.CreateAndUnbox(reader,
                address + 0x00168, relative);
            ChrEditParamBodyPreset =
                Pointer<ParamFileResourceObjectForRegulation<ChrEditParamBodyPreset>>.CreateAndUnbox(reader,
                    address + 0x00170, relative);
            MaterialParam = Pointer<ParamFileResourceObjectForRegulation<MaterialParam>>.CreateAndUnbox(reader,
                address + 0x00178, relative);
            GroundMaterialParam =
                Pointer<ParamFileResourceObjectForRegulation<GroundMaterialParam>>.CreateAndUnbox(reader,
                    address + 0x00180, relative);
            LockOnParam = Pointer<ParamFileResourceObjectForRegulation<LockOnParam>>.CreateAndUnbox(reader,
                address + 0x00188, relative);
            LockTargetParam = Pointer<ParamFileResourceObjectForRegulation<LockTargetParam>>.CreateAndUnbox(reader,
                address + 0x00190, relative);
            LockOnCameraOffsetParam =
                Pointer<ParamFileResourceObjectForRegulation<LockOnCameraOffsetParam>>.CreateAndUnbox(reader,
                    address + 0x00198, relative);
            GuardLevelMotionParam =
                Pointer<ParamFileResourceObjectForRegulation<GuardLevelMotionParam>>.CreateAndUnbox(reader,
                    address + 0x001A0, relative);
            BossParam = Pointer<ParamFileResourceObjectForRegulation<BossParam>>.CreateAndUnbox(reader,
                address + 0x001A8, relative);
            BossPartsParam = Pointer<ParamFileResourceObjectForRegulation<BossPartsParam>>.CreateAndUnbox(reader,
                address + 0x001B0, relative);
            BossPartsModelParam =
                Pointer<ParamFileResourceObjectForRegulation<BossPartsModelParam>>.CreateAndUnbox(reader,
                    address + 0x001B8, relative);
            BossEnemyGenerateParam =
                Pointer<ParamFileResourceObjectForRegulation<BossEnemyGenerateParam>>.CreateAndUnbox(reader,
                    address + 0x001C0, relative);
            GrabParam = Pointer<ParamFileResourceObjectForRegulation<GrabParam>>.CreateAndUnbox(reader,
                address + 0x001C8, relative);
            DeadTypeParam = Pointer<ParamFileResourceObjectForRegulation<DeadTypeParam>>.CreateAndUnbox(reader,
                address + 0x001D0, relative);
            TorchCtrlParam = Pointer<ParamFileResourceObjectForRegulation<TorchCtrlParam>>.CreateAndUnbox(reader,
                address + 0x001D8, relative);
            TorchOffCtrlParam = Pointer<ParamFileResourceObjectForRegulation<TorchOffCtrlParam>>.CreateAndUnbox(reader,
                address + 0x001E0, relative);
            ChrWetParam = Pointer<ParamFileResourceObjectForRegulation<ChrWetParam>>.CreateAndUnbox(reader,
                address + 0x001E8, relative);
            HitBackMatrixParam = Pointer<ParamFileResourceObjectForRegulation<HitBackMatrixParam>>.CreateAndUnbox(
                reader, address + 0x001F0, relative);
            HitBackParam = Pointer<ParamFileResourceObjectForRegulation<HitBackParam>>.CreateAndUnbox(reader,
                address + 0x001F8, relative);
            ChrFullbodySfxParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrFullbodySfxParam>>.CreateAndUnbox(reader,
                    address + 0x00200, relative);
            EnemyAttackMoveParam =
                Pointer<ParamFileResourceObjectForRegulation<EnemyAttackMoveParam>>.CreateAndUnbox(reader,
                    address + 0x00208, relative);
            PlayerStatusNormal = Pointer<ParamFileResourceObjectForRegulation<PlayerStatusNormal>>.CreateAndUnbox(
                reader, address + 0x00210, relative);
            PlayerStatusItemParam =
                Pointer<ParamFileResourceObjectForRegulation<PlayerStatusItemParam>>.CreateAndUnbox(reader,
                    address + 0x00218, relative);
            NpcPlayerStatusParam =
                Pointer<ParamFileResourceObjectForRegulation<NpcPlayerStatusParam>>.CreateAndUnbox(reader,
                    address + 0x00220, relative);
            NpcPlayerSkinParam = Pointer<ParamFileResourceObjectForRegulation<NpcPlayerSkinParam>>.CreateAndUnbox(
                reader, address + 0x00228, relative);
            CriminalAndDeceasedParam =
                Pointer<ParamFileResourceObjectForRegulation<CriminalAndDeceasedParam>>.CreateAndUnbox(reader,
                    address + 0x00230, relative);
            ChrPointWindParam = Pointer<ParamFileResourceObjectForRegulation<ChrPointWindParam>>.CreateAndUnbox(reader,
                address + 0x00238, relative);
            PlayerLightParam = Pointer<ParamFileResourceObjectForRegulation<PlayerLightParam>>.CreateAndUnbox(reader,
                address + 0x00240, relative);
            VowParam = Pointer<ParamFileResourceObjectForRegulation<VowParam>>.CreateAndUnbox(reader, address + 0x00248,
                relative);
            ChrNetworkPhantomParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrNetworkPhantomParam>>.CreateAndUnbox(reader,
                    address + 0x00250, relative);
            ChrNetPhantomSoulRateParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrNetPhantomSoulRateParam>>.CreateAndUnbox(reader,
                    address + 0x00258, relative);
            ChrModelParam = Pointer<ParamFileResourceObjectForRegulation<ChrModelParam>>.CreateAndUnbox(reader,
                address + 0x00260, relative);
            EnemyShotSfxParam = Pointer<ParamFileResourceObjectForRegulation<EnemyShotSfxParam>>.CreateAndUnbox(reader,
                address + 0x00268, relative);
            ChrRoundDamageParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrRoundDamageParam>>.CreateAndUnbox(reader,
                    address + 0x00270, relative);
            ChrRoundDropSoulParam =
                Pointer<ParamFileResourceObjectForRegulation<ChrRoundDropSoulParam>>.CreateAndUnbox(reader,
                    address + 0x00278, relative);
            ChrMultiplayParam = Pointer<ParamFileResourceObjectForRegulation<ChrMultiplayParam>>.CreateAndUnbox(reader,
                address + 0x00280, relative);
            FootEffectWaterSfxParam =
                Pointer<ParamFileResourceObjectForRegulation<FootEffectWaterSfxParam>>.CreateAndUnbox(reader,
                    address + 0x00288, relative);

            return this;
        }
    }
}
