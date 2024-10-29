using Vintagestory.API.Common;
using HarmonyLib;
using Vintagestory.GameContent;
using Vintagestory.API.Server;
using Vintagestory.API.Client;

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
        }   
        
        /// <summary>
        /// Server-specific intialization
        /// </summary>
        public override void StartServerSide(ICoreServerAPI api)
        {
            CoreServerAPI = api;
            if (!Harmony.HasAnyPatches(Mod.Info.ModID)) {
                harmony = new Harmony(Mod.Info.ModID);
                harmony.PatchAll(); // Applies all harmony patches
            }
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(BlockCrop), "OnLoaded")]
        public static void PreOnLoaded() {
            BlockCrop.WildCropDropMul = 0.5f;
        }

        /// <summary>
        /// Unapplies Harmony patches and disposes of all static variables in the ModSystem.
        /// </summary>
        public override void Dispose()
        {
            harmony?.UnpatchAll(Mod.Info.ModID);
        }
}
