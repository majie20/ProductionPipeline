//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class OpenHybridCLRStep : IStep
//    {
//        public void Run()
//        {
//            OtherEditor.SetHybridCLREnable(true);
//            UnityEditor.PlayerSettings.gcIncremental = false;
//            UnityEditor.EditorApplication.UnlockReloadAssemblies();
//            UnityEditor.EditorUtility.RequestScriptReload();
//        }

//        public string EnterText()
//        {
//            return $"����HybridCLR ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����HybridCLR ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return true;
//        }
//    }
//}