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
//            return $"切换为构建运行模式 开始！";
//        }

//        public string ExitText()
//        {
//            return $"切换为构建运行模式 结束！";
//        }

//        public bool IsTriggerCompile()
//        {
//            return false;
//        }
//    }
//}