using System;
using MelonLoader;

namespace FusionVoiceIndicator
{
    public static class Preferences
    {
        private static MelonPreferences_Category currentCategory;
        public static MelonPreferences_Entry<bool> showIndicator;

        public static void Initialize()
        {
            CreateMelonPreferences(MelonPreferences.CreateCategory("FusionVoiceIndicatorMod"));
        }
        private static void CreateMelonPreferences(MelonPreferences_Category category)
        {
            currentCategory = category;
            showIndicator = category.CreateEntry("Show Indicator", false);
        }

        // May need to find a better solution...
        public static void ManualSave()
        {
            currentCategory.SaveToFile();
        }

    }

}