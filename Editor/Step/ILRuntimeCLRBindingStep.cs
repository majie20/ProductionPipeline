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
//            return $"����ILRuntime CLR�� ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����ILRuntime CLR�� ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}