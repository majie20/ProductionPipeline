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
//            return $"设置FmodSettings.ImportType为 {Type} 开始！";
//        }

//        public string ExitText()
//        {
//            return $"设置FmodSettings.ImportType为 {Type} 完成！";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}