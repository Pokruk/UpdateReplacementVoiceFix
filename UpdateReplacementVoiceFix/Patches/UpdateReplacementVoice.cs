using GorillaLocomotion;
using HarmonyLib;
using UnityEngine;

namespace UpdateReplacementVoiceFix.Patches {
    [HarmonyPatch(typeof(VRRig))]
    [HarmonyPatch("UpdateReplacementVoice", MethodType.Normal)]
    internal class FixReplacementVoice {
        public static bool Prefix(VRRig __instance) {
            if (Traverse.Create(__instance).Field("voiceAudio").GetValue() == null) {
                return false;
            }
            return true;
        }
    }
}