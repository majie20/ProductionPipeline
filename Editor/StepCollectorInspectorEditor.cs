using System;
using System.Collections.Generic;
using System.Reflection;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace M.ProductionPipeline
{
    [CustomEditor(typeof(StepCollector))]
    public class StepCollectorInspectorEditor : OdinEditor
    {
        public override void OnInspectorGUI()
        {
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Ö´ÐÐ", GUILayout.Height(40)))
            {
                var collector = target as StepCollector;

                var list = new List<IStep>();

                for (int i = 0; i < collector.Steps.Count; i++)
                {
                    var step = collector.Steps[i];

                    if (step.IsRunning)
                    {
                        var assembly = typeof(StepEditor).Assembly;
                        var type = assembly.GetType(step.FullName);
                        var o = Activator.CreateInstance(type) as IStep;

                        if (!string.IsNullOrEmpty(step.Fields))
                        {
                            var dataList = step.Fields.Split(';');

                            for (int j = 0; j < dataList.Length; j++)
                            {
                                var data = dataList[j].Split('=');
                                var name = data[0];
                                var value = data[1];
                                var field = type.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                                if (field != null)
                                {
                                    if (field.FieldType.IsEnum || field.FieldType == typeof(int))
                                    {
                                        field.SetValue(o, int.Parse(value));
                                    }
                                    else if (field.FieldType == typeof(bool))
                                    {
                                        field.SetValue(o, bool.Parse(value));
                                    }
                                    else
                                    {
                                        field.SetValue(o, value);
                                    }
                                }
                            }
                        }

                        list.Add(o);
                    }
                }

                StepEditor.RunStepGroup(list);
            }

            GUILayout.EndHorizontal();

            base.OnInspectorGUI();
        }
    }
}