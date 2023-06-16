using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace FusionVoiceIndicator
{
    class AssetManager
    {
        static readonly string userDataPath = MelonUtils.UserDataDirectory;
        static readonly string texturesPath = $"{userDataPath}/FusionVoiceIndicator/Images";
        static readonly string microphoneOnTexturePath = $"{texturesPath}/mic.png";

        public static Texture2D microphoneTexture;
        private static void LoadTextures()
        {
            microphoneTexture = new Texture2D(1, 1);
            ImageConversion.LoadImage(microphoneTexture, File.ReadAllBytes(microphoneOnTexturePath));
        }

        private static void CreateDirectories()
        {
            Directory.CreateDirectory(texturesPath);
        }

        public static void Initialize()
        {
            CreateDirectories();
            LoadTextures();
        }
    }
}
