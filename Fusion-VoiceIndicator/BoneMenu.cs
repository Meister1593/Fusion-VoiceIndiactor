using BoneLib.BoneMenu;
using BoneLib.BoneMenu.Elements;
using UnityEngine;

namespace FusionVoiceIndicator
{
    internal class BoneMenu
    {
        private static MenuCategory mainCategory;
        public static void Initialize(){
            mainCategory = MenuManager.CreateCategory("FusionVoiceIndicator", Color.yellow);
            CreateBoneMenu(mainCategory);
        }

        public static void CreateBoneMenu(MenuCategory rootCategory)
        {
            rootCategory.CreateBoolElement("Show indicator", Color.white, FusionVoiceIndicator.Preferences.showIndicator.Value, delegate (bool state)
            {
                FusionVoiceIndicator.Preferences.showIndicator.Value = state;
                FusionVoiceIndicator.Preferences.ManualSave();
            });
        }
    }
}