using BoneLib.BoneMenu.Elements;
using MelonLoader;
using UnityEngine;

namespace FusionVoiceIndicator
{
    internal class BoneMenu
    {
        public static void CreateBoneMenu(MenuCategory rootCategory)
        {
            rootCategory.CreateBoolElement("Show indicator", Color.white, FusionVoiceIndicator.Preferences.showIndicator.Value, delegate (bool state)
            {
                FusionVoiceIndicator.Preferences.showIndicator.Value = state;
                FusionVoiceIndicator.Preferences.ManualSave();
            });
            rootCategory.CreateBoolElement("Play sound", Color.white, FusionVoiceIndicator.Preferences.playSound.Value, delegate (bool state)
            {
                FusionVoiceIndicator.Preferences.playSound.Value = state;
                FusionVoiceIndicator.Preferences.ManualSave();
            });
            rootCategory.CreateFloatElement("Sound volume", Color.white, FusionVoiceIndicator.Preferences.soundVolume.Value, 0.1f, 0.0f, 1.0f, delegate (float state)
            {
                FusionVoiceIndicator.Preferences.soundVolume.Value = state;
                FusionVoiceIndicator.Preferences.ManualSave();
            });
        }
    }
}