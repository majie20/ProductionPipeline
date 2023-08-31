using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

namespace M.ProductionPipeline
{
    [CreateAssetMenu(fileName = "StepSaveSettings", menuName = "ScriptableObjects/StepSaveSettings", order = 10)]
    public class StepSaveSettings : SerializedScriptableObject
    {
        [ReadOnly]
        public StepSave StepSave;

        [ReadOnly]
        public bool IsRunning;

        private static StepSaveSettings _settings;

        public static StepSaveSettings Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = AssetDatabase.LoadAssetAtPath<StepSaveSettings>("Assets/ProductionPipeline/Editor/StepSaveSettings.asset");
                }

                return _settings;
            }
        }

        [Button("���")]
        public static void Clear()
        {
            Settings.StepSave = null;
            Settings.IsRunning = false;
            EditorUtility.SetDirty(Settings);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}