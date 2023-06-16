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
            VoiceIndicatorObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            VoiceIndicatorObject.name = VoiceIndicatorName;
            VoiceIndicatorObject.transform.localPosition = Vector3.forward * 1.5f;
            VoiceIndicatorObject.transform.SetParent(Head.transform);

            var mat = new Material(Shader.Find("Universal Render Pipeline/Lit (PBR Workflow)"));
            mat.color = Color.red;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().material = mat;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().materials = new Material[] { mat };
            VoiceIndicatorObject.GetComponent<MeshRenderer>().sharedMaterial = mat;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().sharedMaterials = new Material[] { mat };
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