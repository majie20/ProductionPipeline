//using FMODUnity;
//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class FmodSettingsStep : IStep
//    {
//        public ImportType Type;

//        public void Run()
//        {
//            Settings.Instance.ImportType = Type;
//            EditorUtility.SetDirty(Settings.Instance);

//            AssetDatabase.SaveAssets();
//            AssetDatabase.Refresh();
//        }

//        public string EnterText()
//        {
//            return $"����FmodSettings.ImportTypeΪ {Type} ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����FmodSettings.ImportTypeΪ {Type} ��ɣ�";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}