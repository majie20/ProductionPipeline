//using Model;
//using UnityEditor;
//using YooAsset;

//namespace M.ProductionPipeline
//{
//    public class BuildPlayModeStep : IStep
//    {
//        public void Run()
//        {
//            var settings = AssetDatabase.LoadAssetAtPath<AssetsBundleSettings>(EditorConst.ASSETS_BUNDLE_SETTINGS_PATH);

//            if (settings.IsOfflineGame)
//            {
//                settings.PlayMode = EPlayMode.OfflinePlayMode;
//            }
//            else
//            {
//                settings.PlayMode = EPlayMode.HostPlayMode;
//            }

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