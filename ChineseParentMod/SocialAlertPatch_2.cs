using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace ChineseParentMod
{
    [HarmonyPatch(typeof(NewSocialGirlMgr), "CheckShowAlert")]
    public static class SocialAlertPatch_2
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
