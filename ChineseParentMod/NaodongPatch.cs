using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace ChineseParentMod
{
    [HarmonyPatch(typeof(naodong), "Dig")]
    public static class NaodongPatch
    {
        public static void Prefix(TableSOItemNaodong __instance)
        {
            if (__instance.magic_type == 0 || __instance.magic_type == 9 || __instance.magic_type == 11)
            {
                __instance.magic_type = 2;
            }
            return;
        }
    }
}
