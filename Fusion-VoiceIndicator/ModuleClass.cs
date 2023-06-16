using LabFusion.SDK.Modules;
using MelonLoader;

namespace FusionVoiceIndicator {
    public class ModuleClass : Module {
        public override void OnModuleLoaded()
        {
            MelonLogger.Msg("Started loading FusionVoiceIndicator Module.");
            //LabFusion.Utilities.MultiplayerHooking.OnJoinServer += VoiceIndicator.Initialize;
            //LabFusion.Utilities.MultiplayerHooking.OnDisconnect += VoiceIndicator.Uninitialize;
            MelonLogger.Msg("Loaded FusionVoiceIndicator Module!");
        }
    }
}