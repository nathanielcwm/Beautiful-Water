using RimWorld;
using Verse;
using UnityEngine;

namespace Beautiful_Water
{
    public class Settings : ModSettings
    {
        public float WaterShallow = 1.0f;

        public override void ExposeData()
        {
            Scribe_Values.Look<float>(ref WaterShallow, "bwWaterShallow", 1f, false);
            base.ExposeData();
        }
    }

    [StaticConstructorOnStartup]
    public class WaterMod : Mod
    {
        Settings settings;
        static WaterMod()
        {
            Log.Message("Hello World!");
        }
        public WaterMod(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<Settings>();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);

            listing_Standard.Label("Shallow Water Beauty");
            settings.WaterShallow = listing_Standard.Slider(settings.WaterShallow, -50f, 50f);

            listing_Standard.End();
        }

        public override string SettingsCategory()
        {
            return "Beautiful Water (Fork)";
        }
    }
}
