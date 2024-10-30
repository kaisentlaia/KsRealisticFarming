using Vintagestory.API.Common;
using HarmonyLib;
using Vintagestory.GameContent;
using Vintagestory.API.Server;
using Vintagestory.API.Client;
using Vintagestory.API.Util;
using System.Linq;

namespace KsRealisticFarming;

[HarmonyPatch]
public class KsRealisticFarmingModSystem : ModSystem
{
        public Harmony harmony;
        public static ICoreAPI CoreAPI;
        public static ICoreServerAPI CoreServerAPI;
        public static ICoreClientAPI CoreClientAPI;

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            CoreAPI = api;
            if (!Harmony.HasAnyPatches(Mod.Info.ModID)) {
                harmony = new Harmony(Mod.Info.ModID);
                harmony.PatchAll(); // Applies all harmony patches
            }
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(BlockCrop), nameof(BlockCrop.OnLoaded))]
        public static void PreOnLoaded() {
            BlockCrop.WildCropDropMul = 0.5f;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(BlockCrop), "GetPlacedBlockInteractionHelp")]
        public static WorldInteraction[] PostGetPlacedBlockInteractionHelp(WorldInteraction[] __result, BlockCrop __instance)
        {
            bool isVegetable = __instance.Code.Path.Contains("cabbage") ||
                __instance.Code.Path.Contains("carrot") ||
                __instance.Code.Path.Contains("turnip") ||
                __instance.Code.Path.Contains("cassava") ||
                __instance.Code.Path.Contains("onion") ||
                __instance.Code.Path.Contains("parsnip");
            WorldInteraction[] interactions;
            if (isVegetable) {
                interactions = new WorldInteraction[3] {
                    new WorldInteraction()
                    {
                        ActionLangCode = "ksrealisticfarming:blockhelp-crop-breaktoharvest-partial",
                        MouseButton = EnumMouseButton.Left,
                        ShouldApply = (WorldInteraction wi, BlockSelection bs, EntitySelection es) => __instance.CurrentCropStage == __instance.CropProps.GrowthStages - 2
                    },
                    new WorldInteraction()
                    {
                        ActionLangCode = "blockhelp-crop-breaktoharvest",
                        MouseButton = EnumMouseButton.Left,
                        ShouldApply = (WorldInteraction wi, BlockSelection bs, EntitySelection es) => __instance.CurrentCropStage == __instance.CropProps.GrowthStages - 1
                    },
                    new WorldInteraction()
                    {
                        ActionLangCode = "ksrealisticfarming:blockhelp-crop-breaktoharvest-seeds",
                        MouseButton = EnumMouseButton.Left,
                        ShouldApply = (WorldInteraction wi, BlockSelection bs, EntitySelection es) => __instance.CurrentCropStage == __instance.CropProps.GrowthStages
                    },
                };
            } else {
                interactions = new WorldInteraction[2] {
                    new WorldInteraction()
                    {
                        ActionLangCode = "ksrealisticfarming:blockhelp-crop-breaktoharvest-partial",
                        MouseButton = EnumMouseButton.Left,
                        ShouldApply = (WorldInteraction wi, BlockSelection bs, EntitySelection es) => __instance.CurrentCropStage == __instance.CropProps.GrowthStages - 1
                    },
                    new WorldInteraction()
                    {
                        ActionLangCode = "blockhelp-crop-breaktoharvest",
                        MouseButton = EnumMouseButton.Left,
                        ShouldApply = (WorldInteraction wi, BlockSelection bs, EntitySelection es) => __instance.CurrentCropStage == __instance.CropProps.GrowthStages
                    }
                };
            }
            return interactions.Append(__result.Remove(__result.First()));
        }

        /// <summary>
        /// Unapplies Harmony patches and disposes of all static variables in the ModSystem.
        /// </summary>
        public override void Dispose()
        {
            harmony?.UnpatchAll(Mod.Info.ModID);
        }
}
