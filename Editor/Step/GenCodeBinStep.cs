//using System.IO;
//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class GenCodeBinStep : IStep
//    {
//        public void Run()
//        {
//            UnityEditor.AssetDatabase.DeleteAsset(EditorConst.JSON_CONFIG);
//            EditorHelper.RunMyBat("gen_code_binһ������.bat", "../Excel/");
//            AssetDatabase.SaveAssets();
//            AssetDatabase.Refresh();
//        }

//        public string EnterText()
//        {
//            return $"����Excel�������Ƹ�ʽ ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����Excel�������Ƹ�ʽ ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}