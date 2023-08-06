using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace ChineseParentMod
{
    [BepInPlugin("ChineseParent.Mod","中国式家长Mod","2.0")]
    public class Main : BaseUnityPlugin
    {
        public static ConfigEntry<bool> ModConfig;
        public void Start()
        {
            ModConfig = Config.Bind("Mod设置", "Mod开关", true, "");

            if (ModConfig.Value != true)
            {
                return;
            }
            new Harmony("ChineseParent.Mod").PatchAll();
        }
    }
}
