using System.Linq;
using UnityEditor;
using UnityEngine;

namespace M.ProductionPipeline
{
    public class AddDefineStep : IStep
    {
        public string Name;

        public void Run()
        {
            EditorHelper.AddDefineSymbols(Name, BuildTargetGroup.Standalone);
            EditorHelper.AddDefineSymbols(Name, BuildTargetGroup.iOS);
            EditorHelper.AddDefineSymbols(Name, BuildTargetGroup.Android);
        }

        public string EnterText()
        {
            return $"��� {Name} �궨�忪ʼ��";
        }

        public string ExitText()
        {
            return $"��� {Name} �궨�������";
        }

        public bool IsTriggerCompile()
        {
            var defineTexts = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';').ToList();

            return !defineTexts.Contains(Name);
        }
    }
}