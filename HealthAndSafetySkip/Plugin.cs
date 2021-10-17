using HarmonyLib;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace HealthAndSafetySkip
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static IPALogger Log { get; private set; }

        private const string _harmonyId = "de.sneakometer.HealthAndSafetySkip";
        internal static Harmony Harmony { get; private set; }

        [Init]
        public void Init(IPALogger logger)
        {
            Log = logger;
            Harmony = new Harmony(_harmonyId);
            Log.Info("HealthAndSafetySkip initialized.");
        }

        [OnEnable]
        public void OnEnable()
        => Harmony.PatchAll(Assembly.GetExecutingAssembly());

        [OnDisable]
        public void OnDisable()
            => Harmony.UnpatchAll(_harmonyId);
    }
}
