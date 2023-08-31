//using Model;
//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class ILRuntimeCLRBindingStep : IStep
//    {
//        public void Run()
//        {
//            if (AssetDatabase.LoadAssetAtPath<AssetsBundleSettings>(EditorConst.ASSETS_BUNDLE_SETTINGS_PATH).HotfixMode == HotfixMode.ILRunTime)
//            {
//#if ILRuntime
//                ILRuntimeCLRBinding.GenerateClrBindingByAnalysis();
//#endif
//            }
//        }

//        public string EnterText()
//        {
//            return $"设置ILRuntime CLR绑定 开始！";
//        }

//        public string ExitText()
//        {
//            return $"设置ILRuntime CLR绑定 结束！";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}