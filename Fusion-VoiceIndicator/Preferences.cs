using MelonLoader;

namespace FusionVoiceIndicator
{
    internal static class Preferences
    {
        private static MelonPreferences_Category currentCategory;
        public static MelonPreferences_Entry<bool> showIndicator;
        public static MelonPreferences_Entry<bool> playSound;
        public static MelonPreferences_Entry<float> soundVolume;

        public static void CreateMelonPreferences(MelonPreferences_Category category)
        {
            currentCategory = category;
            showIndicator = category.CreateEntry("Show Indicator", true);
            playSound = category.CreateEntry("Play Sound", true);
            soundVolume = category.CreateEntry("Sound volume", 1.0f);
        }

        // May need to find a better solution...
        public static void ManualSave()
        {
            currentCategory.SaveToFile();
        }
    }

}