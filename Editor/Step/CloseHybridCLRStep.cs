//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class CloseHybridCLRStep : IStep
//    {
//        public void Run()
//        {
//            OtherEditor.SetHybridCLREnable(false);
//            UnityEditor.PlayerSettings.gcIncremental = true;
//            UnityEditor.EditorApplication.UnlockReloadAssemblies();
//            UnityEditor.EditorUtility.RequestScriptReload();
//        }

//        public string EnterText()
//        {
//            return $"�ر�HybridCLR ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"�ر�HybridCLR ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return true;
//        }
//    }
//}