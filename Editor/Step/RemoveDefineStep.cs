using System.Linq;
using UnityEditor;

namespace M.ProductionPipeline
{
    public class RemoveDefineStep : IStep
    {
        public string Name;

        public void Run()
        {
            EditorHelper.RemoveDefineSymbols(Name, BuildTargetGroup.Standalone);
            EditorHelper.RemoveDefineSymbols(Name, BuildTargetGroup.iOS);
            EditorHelper.RemoveDefineSymbols(Name, BuildTargetGroup.Android);
        }

        public string EnterText()
        {
            return $"�Ƴ� {Name} �궨�忪ʼ��";
        }

        public string ExitText()
        {
            return $"�Ƴ� {Name} �궨�������";
        }

        public bool IsTriggerCompile()
        {
            var defineTexts = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';').ToList();

            return defineTexts.Contains(Name);
        }
    }
}