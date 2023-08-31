using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace M.ProductionPipeline
{
    [CreateAssetMenu(fileName = "StepCollector", menuName = "ScriptableObjects/StepCollector", order = 11)]
    public class StepCollector : SerializedScriptableObject
    {
        [ListDrawerSettings(ShowPaging = false, Expanded = true)]
        public List<Step> Steps;
    }
}