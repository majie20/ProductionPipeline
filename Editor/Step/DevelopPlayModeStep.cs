//using Model;
//using UnityEditor;
//using YooAsset;

//namespace M.ProductionPipeline
//{
//    public class DevelopPlayModeStep : IStep
//    {
//        public void Run()
//        {
//            var settings = AssetDatabase.LoadAssetAtPath<AssetsBundleSettings>(EditorConst.ASSETS_BUNDLE_SETTINGS_PATH);
//            settings.PlayMode = EPlayMode.EditorSimulateMode;

//            EditorUtility.SetDirty(settings);
//            AssetDatabase.SaveAssets();
//            AssetDatabase.Refresh();
//        }

//        public string EnterText()
//        {
//            return $"�л�Ϊ��������ģʽ ��ʼ��";
//        }

//        public string ExitText()
//        {
//            return $"�л�Ϊ��������ģʽ ������";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}