using LabFusion.SDK.Modules;
using MelonLoader;

namespace FusionVoiceIndicator {
    public class ModuleClass : Module {
        public override void OnModuleLoaded()
        {
            MelonLogger.Msg("Loaded FusionVoiceIndicator Module!");
        }
    }
}