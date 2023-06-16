using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FusionVoiceIndicator
{
    class VoiceIndicator
    {
        private static string VoiceIndicatorName = "VoiceIndicator";
        private static GameObject Head;
        private static GameObject VoiceIndicatorObject;
        public static void Initialize()
        {
            Head = GameObject.Find("TrackingSpace/Head");
            var distanceFromHead = 10;
            VoiceIndicatorObject = new GameObject()
            {
                name = VoiceIndicatorName
            };
            VoiceIndicatorObject.transform.SetParent(Head.transform);
            VoiceIndicatorObject.transform.localPosition = Vector3.forward * distanceFromHead;

            var scaleRoot = new GameObject()
            {
                name = "ScaleRoot"
            };
            scaleRoot.transform.SetParent(VoiceIndicatorObject.transform);
            scaleRoot.transform.localPosition = Vector3.zero;   // change scale pos here (locally)

            var voiceVolumeMeshGo = GameObject.CreatePrimitive(PrimitiveType.Quad);
            voiceVolumeMeshGo.transform.SetParent(scaleRoot.transform);
            voiceVolumeMeshGo.transform.position = Vector3.up * 1.5f;
            MelonLogger.Msg("Initialized VoiceIndicator");
        }
        public static void Uninitialize()
        {
            GameObject.Destroy(VoiceIndicatorObject);
            VoiceIndicatorObject = null;
            MelonLogger.Msg("Destroyed VoiceIndicator");
        }
    }
}