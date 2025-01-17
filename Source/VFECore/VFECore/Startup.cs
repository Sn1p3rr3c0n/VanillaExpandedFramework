﻿using RimWorld;
using UnityEngine;
using Verse;

namespace VFECore
{
    [StaticConstructorOnStartup]
    public static class Startup
    {
        public static Mesh plane20Flip = MeshMakerPlanes.NewPlaneMesh(2f, true);

        static Startup()
        {
            // Cache setters
            PawnShieldGenerator.Reset();
            ScenPartUtility.SetCache();
            CheckXmlErrors();
        }

        public static void CheckXmlErrors()
        {
            foreach (var def in DefDatabase<WorkGiverDef>.AllDefs)
            {
                if (def.giverClass is null)
                {
                    Log.Error(def.defName + " is missing worker class and will not work properly. Report about it to " + def.modContentPack?.Name + " devs.");
                }
            }
            foreach (var def in DefDatabase<ThingDef>.AllDefs)
            {
                if (def.thingClass is null)
                {
                    Log.Error(def.defName + " is missing thing class and will not work properly. Report about it to " + def.modContentPack?.Name + " devs.");
                }
            }
        }

    }
}