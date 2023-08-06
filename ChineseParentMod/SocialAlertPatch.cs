using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace ChineseParentMod
{
    [HarmonyPatch(typeof(NewSocialBoyMgr), "CheckShowAlert")]
    public static class SocialAlertPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
