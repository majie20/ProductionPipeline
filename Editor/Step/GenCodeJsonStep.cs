//using UnityEditor;

//namespace M.ProductionPipeline
//{
//    public class GenCodeJsonStep : IStep
//    {
//        public void Run()
//        {
//            UnityEditor.AssetDatabase.DeleteAsset(EditorConst.JSON_CONFIG);
//            EditorHelper.RunMyBat("gen_code_jsonһ������.bat", "../Excel/");
//            AssetDatabase.SaveAssets();
//            AssetDatabase.Refresh();
//        }

//        public string EnterText()
//        {
//            return $"����Excel����ͨ��ʽ ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"����Excel����ͨ��ʽ ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}