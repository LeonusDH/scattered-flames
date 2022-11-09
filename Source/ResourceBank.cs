
using RimWorld;
using Verse;
using UnityEngine;

namespace ScatteredFlames
{
    [StaticConstructorOnStartup]
    public static class ResourceBank
    {
		[DefOf]
		public static class FleckDefOf
        {
            public static FleckDef Owl_LongFireGlow;
        }

        public static Color color = Color.white;
        public static Graphic FireGraphic = GraphicDatabase.Get<Graphic_Flicker>("Things/Special/Fire", ShaderDatabase.TransparentPostLight, Vector2.one, Color.white);
        public static Texture2D IgniteIcon = ContentFinder<Texture2D>.Get("Things/Building/Misc/TorchLamp_MenuIcon");
    }
}
