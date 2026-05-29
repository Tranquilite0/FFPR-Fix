using HarmonyLib;
using System;
using System.IO;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using Last.UI;
using Il2CppSystem.Input;

namespace FFPR_Fix.Patches
{
    public static class UnmapAutoDashKey
    {
        [HarmonyPatch(typeof(FieldMap), nameof(FieldMap.LateUpdate))]
        [HarmonyPrefix]
        public static void UnmapAutoDashKeyFunc(FieldMap __instance)
        {
            if (__instance.keyAutoDash != Key.Select &&
                Plugin.Config.RemapSpeedUpToL3.Value)
            {
                __instance.keyAutoDash = Key.Select;
            }
        }
    }
}
