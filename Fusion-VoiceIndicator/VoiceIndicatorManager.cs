using MelonLoader;

namespace FusionVoiceIndicator
{
    public static class VoiceIndicatorManager
    {
        public delegate void HasVoiceActivity(bool hasVoiceData);
        public static HasVoiceActivity HasVoiceActivityListener;
        private static bool VoiceActivityState;
        private static bool MuteState;
        public static void Initialize()
        {
            LabFusion.Preferences.FusionPreferences.ClientSettings.Muted.OnValueChanged += MutedStateListener;
            HasVoiceActivityListener = new HasVoiceActivity(VoiceActivityListener);
            MelonLogger.Msg($"Loaded VoiceIndicatorManager");
        }

        public static void MutedStateListener(bool muteState)
        {
            MuteState = muteState;
            if (muteState)
            {
                AudioManager.Play(AssetManager.muteAudio);
            }
            else
            {
                AudioManager.Play(AssetManager.unmuteAudio);
            }
            MelonLogger.Msg($"Muted state now: {MuteState}");
        }

        public static void VoiceActivityListener(bool voiceActivityState)
        {
            if (voiceActivityState != VoiceActivityState)
            {
                MelonLogger.Msg($"Voice activity changed: {voiceActivityState}");
            }
            VoiceActivityState = voiceActivityState;
        }

    }
}