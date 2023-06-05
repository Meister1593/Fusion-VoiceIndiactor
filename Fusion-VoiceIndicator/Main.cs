using MelonLoader;
using BoneLib.BoneMenu;

using UnityEngine;
namespace FusionVoiceIndicator
{
    internal partial class Main : MelonMod
    {

        public override void OnInitializeMelon()
        {
            FusionVoiceIndicator.Preferences.CreateMelonPreferences(MelonLoader.MelonPreferences.CreateCategory("Fusion-VoiceIndicator"));
            FusionVoiceIndicator.BoneMenu.CreateBoneMenu(MenuManager.CreateCategory("Fusion-VoiceIndicator", Color.white));
            AssetManager.Initialize();
            base.OnInitializeMelon();
        }
    }
}