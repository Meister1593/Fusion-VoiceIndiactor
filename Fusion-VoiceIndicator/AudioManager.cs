using UnityEngine;

namespace FusionVoiceIndicator
{
    public static class AudioManager
    {
        private static GameObject audioManagerObject;

        public static void Play(AudioClip clip)
        {
            audioManagerObject = audioManagerObject ? audioManagerObject : new GameObject("Fusion-VoiceIndicator AudioManager");
            AudioSource audioSource = audioManagerObject.GetComponent<AudioSource>() ? audioManagerObject.GetComponent<AudioSource>() : audioManagerObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(clip, 0.7f);
        }
    }
}