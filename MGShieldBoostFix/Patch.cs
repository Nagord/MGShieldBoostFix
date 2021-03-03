using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace MGShieldBoostFix
{
    [HarmonyPatch(typeof(PLWarpDriveProgram), "FinalLateAddStats")]
    class Patch
    {
        static void Postfix(PLWarpDriveProgram __instance, PLShipStats inStats)//The devs were sill and added every number nececary but forgot to actually change the shield numbers
        {
            if (Time.time - (float)__instance.GetType().GetField("SuperShieldBooster_LastActivationTime", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(__instance) < (float)__instance.GetType().GetField("SuperShieldBooster_ActiveTime", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(__instance))
            {
                //PulsarPluginLoader.Utilities.Logger.Info("Working");
                float DontReflectOnItTooMuch = (float)__instance.GetType().GetField("SuperShieldBooster_BoostAmount", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(__instance);
                inStats.ShieldsChargeRate += DontReflectOnItTooMuch;
                inStats.ShieldsChargeRateMax += DontReflectOnItTooMuch;
            }
        }
    }

}
