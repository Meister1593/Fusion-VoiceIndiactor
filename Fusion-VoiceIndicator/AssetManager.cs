using System.IO;

using MelonLoader;
using UnityEngine;
using AudioImportLib;

namespace FusionVoiceIndicator
{
    internal static class AssetManager
    {
        static readonly string userDataPath = MelonUtils.UserDataDirectory;
        static readonly string modStoragePath = $"{userDataPath}/Fusion-VoiceIndicator";
        static readonly string audioPath = $"{modStoragePath}/Audio";

        public static AudioClip muteAudio;
        public static AudioClip unmuteAudio;

        private static void LoadAudio()
        {
            muteAudio = API.LoadAudioClip($"{audioPath}/mute_audio.wav", true);
            unmuteAudio = API.LoadAudioClip($"{audioPath}/unmute_audio.wav", true);
        }

        private static void CreateDirectories()
        {
            Directory.CreateDirectory(audioPath);
        }

        public static void Initialize()
        {
            CreateDirectories();
            LoadAudio();
        }
    }
}