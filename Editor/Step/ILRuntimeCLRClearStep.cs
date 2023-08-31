//using System.IO;
//using Model;
//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class ILRuntimeCLRClearStep : IStep
//    {
//        public void Run()
//        {
//            if (AssetDatabase.LoadAssetAtPath<AssetsBundleSettings>(EditorConst.ASSETS_BUNDLE_SETTINGS_PATH).HotfixMode == HotfixMode.ILRunTime)
//            {
//#if ILRuntime
//                ILRuntimeCLRBinding.DeleteAllAndGenerateClrBindingByAnalysis();
//#endif
//            }
//        }

//        public string EnterText()
//        {
//            return $"清理ILRuntime CLR绑定 开始！";
//        }

//        public string ExitText()
//        {
//            return $"清理ILRuntime CLR绑定 结束！";
//        }

//        public bool IsTriggerCompile()
//        {
//            if (Directory.Exists(EditorConst.ILBINDING))
//            {
//                string[] files = System.IO.Directory.GetFiles(EditorConst.ILBINDING);

//                return files.Length > 0;
//            }

//            return false;
//        }
//    }
//}