using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace HealthAndSafetySkip.Patches
{
    [HarmonyPatch(typeof(HealthWarningFlowCoordinator), "Update")]
    internal class HealthWarningFlowCoordinatorPatch
    {
        internal static void Prefix(HealthWarningFlowCoordinator __instance)
        {
            __instance.GoToNextScene();
        }
    }
}