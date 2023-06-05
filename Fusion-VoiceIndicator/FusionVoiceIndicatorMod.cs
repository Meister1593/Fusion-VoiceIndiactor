using MelonLoader;
using LabFusion.SDK.Modules;
using LabFusion.Network;
using Steamworks;

namespace FusionVoiceIndicator
{
    public class FusionVoiceIndicatorMod : MelonMod
    {

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading...");
            ModuleHandler.LoadModule(System.Reflection.Assembly.GetExecutingAssembly());
            AssetManager.Initialize();
            VoiceIndicatorManager.Initialize();
            Preferences.Initialize();
            BoneMenu.Initialize();
            MelonLogger.Msg("Loaded mod.");
        }

        public override void OnUpdate()
        {
            if (NetworkInfo.IsServer)
            {
                VoiceIndicatorManager.HasVoiceActivityListener(SteamUser.HasVoiceData);
            }
        }
    }
}