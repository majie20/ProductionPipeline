using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

public class EditorHelper
{
    public static System.Diagnostics.Process CreateShellExProcess(string cmd, string args, string workingDir = "")
    {
        var pStartInfo = new System.Diagnostics.ProcessStartInfo(cmd);
        pStartInfo.Arguments = args;
        pStartInfo.CreateNoWindow = false;
        pStartInfo.UseShellExecute = true;
        pStartInfo.RedirectStandardError = false;
        pStartInfo.RedirectStandardInput = false;
        pStartInfo.RedirectStandardOutput = false;

        if (!string.IsNullOrEmpty(workingDir))
            pStartInfo.WorkingDirectory = workingDir;

        return System.Diagnostics.Process.Start(pStartInfo);
    }

    public static void RunBat(string batfile, string args, string workingDir = "")
    {
        var p = CreateShellExProcess(batfile, args, workingDir);
        p.Close();
    }

    public static void RunMyBat(string batFile, string workingDir)
    {
        if (!System.IO.Directory.Exists(workingDir))
        {
            Debug.LogError($"不存在的路径：{workingDir}");
        }
        else if (!System.IO.File.Exists($"{workingDir}{batFile}"))
        {
            Debug.LogError($"不存在的bat文件：{workingDir}{batFile}");
        }
        else
        {
            var path = FormatPath(workingDir);
            EditorHelper.RunBat(batFile, "", path);
        }
    }

    public static string FormatPath(string path)
    {
        path = path.Replace("/", "\\");

        if (Application.platform == RuntimePlatform.OSXEditor)
            path = path.Replace("\\", "/");

        return path;
    }

    public static void AddDefineSymbols(string str, BuildTargetGroup group)
    {
        var defineTexts = PlayerSettings.GetScriptingDefineSymbolsForGroup(group).Split(';').ToList();

        if (!defineTexts.Contains(str))
        {
            defineTexts.Add(str);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < defineTexts.Count; i++)
            {
                sb.Append(defineTexts[i]);

                if (i != defineTexts.Count - 1)
                {
                    sb.Append(";");
                }
            }

            PlayerSettings.SetScriptingDefineSymbolsForGroup(group, sb.ToString());
        }
    }

    public static void RemoveDefineSymbols(string str, BuildTargetGroup group)
    {
        var defineTexts = PlayerSettings.GetScriptingDefineSymbolsForGroup(group).Split(';').ToList();

        if (defineTexts.Contains(str))
        {
            defineTexts.Remove(str);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < defineTexts.Count; i++)
            {
                sb.Append(defineTexts[i]);

                if (i != defineTexts.Count - 1)
                {
                    sb.Append(";");
                }
            }

            PlayerSettings.SetScriptingDefineSymbolsForGroup(group, sb.ToString());
        }
    }

    private static MethodInfo _clearConsoleMethod;

    public static void ClearConsole()
    {
        if (_clearConsoleMethod == null)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
            System.Type logEntries = assembly.GetType("UnityEditor.LogEntries");
            _clearConsoleMethod = logEntries.GetMethod("Clear");
        }

        _clearConsoleMethod.Invoke(new object(), null);
    }
}