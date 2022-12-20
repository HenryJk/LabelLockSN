using BepInEx;
using HarmonyLib;

namespace LabelLockSN
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class LabelLock : BaseUnityPlugin {
        public static LabelLock Instance { get; private set; }

        public Harmony Harmony { get; } = new Harmony(PluginInfo.PLUGIN_GUID);

        private void Awake() {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
