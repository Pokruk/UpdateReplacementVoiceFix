using BepInEx;
using System;
using UnityEngine;

namespace UpdateReplacementVoiceFix {
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin {
        void OnEnable() {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable() {
            HarmonyPatches.RemoveHarmonyPatches();
        }
    }
}
