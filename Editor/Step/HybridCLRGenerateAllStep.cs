using UnityEditor;
using UnityEditor.Build;

namespace M.ProductionPipeline
{
    public class HybridCLRGenerateAllStep : IStep
    {
        public void Run()
        {
            //Il2CppCodeGeneration.OptimizeSize
        }

        public string EnterText()
        {
            return $"ִ��HybridCLR ��ʼ��";
        }

        public string ExitText()
        {
            return $"����������Դ��ʽ ������";
        }

        public bool IsTriggerCompile()
        {
            return false;
        }
    }
}