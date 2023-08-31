//using System.IO;
//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class GenCodeBinStep : IStep
//    {
//        public void Run()
//        {
//            UnityEditor.AssetDatabase.DeleteAsset(EditorConst.JSON_CONFIG);
//            EditorHelper.RunMyBat("gen_code_bin一键导出.bat", "../Excel/");
//            AssetDatabase.SaveAssets();
//            AssetDatabase.Refresh();
//        }

//        public string EnterText()
//        {
//            return $"导出Excel表，二进制格式 开始！";
//        }

//        public string ExitText()
//        {
//            return $"导出Excel表，二进制格式 结束！";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}