using HarmonyLib;

namespace LabelLockSN {

    [HarmonyPatch(typeof(uGUI_SignInput), nameof(uGUI_SignInput.Awake))]
    internal class PatchSignInputAwake {
        [HarmonyPostfix]
        public static void Postfix(uGUI_SignInput __instance) =>
            Toggler.Instance().trackedSigns.Add(__instance);
    }

    [HarmonyPatch(typeof(uGUI_SignInput), nameof(uGUI_SignInput.Destroy))]
    internal class PatchSignInputDestroy {
        [HarmonyPrefix]
        public static void Prefix(uGUI_SignInput __instance) =>
            Toggler.Instance().trackedSigns.Remove(__instance);
    }
}
