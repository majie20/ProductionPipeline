//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class OpenILRuntimeStep : IStep
//    {
//        public void Run()
//        {
//            if (System.IO.Directory.Exists(EditorConst.PLUGINS_ILRUNTIME_))
//            {
//                UnityEditor.FileUtil.ReplaceDirectory(EditorConst.PLUGINS_ILRUNTIME_, EditorConst.PLUGINS_ILRUNTIME);
//                UnityEditor.FileUtil.DeleteFileOrDirectory(EditorConst.PLUGINS_ILRUNTIME_);
//            }

//            if (System.IO.Directory.Exists(EditorConst.THIRDPARTY_ILRUNTIME_))
//            {
//                UnityEditor.FileUtil.ReplaceDirectory(EditorConst.THIRDPARTY_ILRUNTIME_, EditorConst.THIRDPARTY_ILRUNTIME);
//                UnityEditor.FileUtil.DeleteFileOrDirectory(EditorConst.THIRDPARTY_ILRUNTIME_);
//            }
//        }

//        public string EnterText()
//        {
//            return $"����ILRuntime ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����ILRuntime ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return System.IO.Directory.Exists(EditorConst.PLUGINS_ILRUNTIME_);
//        }
//    }
//}