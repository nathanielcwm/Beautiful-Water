using RimWorld;
using Verse;
using UnityEngine;
using HugsLib;
using HugsLib.Settings;

namespace Beautiful_Water
{
    public class WaterSettings : ModBase
    {
        public override string ModIdentifier
        {
            get { return "BeautifulWater"; }
        }
        private SettingHandle WaterShallow;
        public override void DefsLoaded()
        {
            WaterShallow = Settings.GetHandle("WaterShallow", "Shallow Water", "Min: -100, Max: 100", 1, Validators.IntRangeValidator(-100, 100));
        }
    }

    [StaticConstructorOnStartup]
    public class WaterMod
    {
        static WaterMod()
        {
            Log.Message("Hello World!");
        }
    }
}
