using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FusionVoiceIndicator
{
    class VoiceIndicator
    {
        private static string VoiceIndicatorName = "VoiceIndicator";
        private static GameObject VoiceIndicatorObject;
        private static Material IndicatorMaterial;
        public static void Initialize()
        {
            GameObject head = GameObject.Find("TrackingSpace/Head"); // todo: use absolute path because fusion also has the same thing
            VoiceIndicatorObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
            VoiceIndicatorObject.name = VoiceIndicatorName;
            VoiceIndicatorObject.transform.localPosition = Vector3.forward * 1.5f;
            VoiceIndicatorObject.transform.SetParent(head.transform);

            var IndicatorMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit (PBR Workflow)"));
            IndicatorMaterial.color = Color.red;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().material = IndicatorMaterial;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().materials = new Material[] { IndicatorMaterial };
            VoiceIndicatorObject.GetComponent<MeshRenderer>().sharedMaterial = IndicatorMaterial;
            VoiceIndicatorObject.GetComponent<MeshRenderer>().sharedMaterials = new Material[] { IndicatorMaterial };
            MelonLogger.Msg("Initialized VoiceIndicator");
        }
        public static void Uninitialize()
        {
            GameObject.Destroy(VoiceIndicatorObject);
            Material.Destroy(IndicatorMaterial);
            VoiceIndicatorObject = null;
            MelonLogger.Msg("Destroyed VoiceIndicator");
        }
    }
}