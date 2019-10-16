using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEditor;

public class BatchMode{
 static List<string> levels = new List<string>();
 
    public static void BuildAndroid()
    {       
        foreach (EditorBuildSettingsScene item in EditorBuildSettings.scenes)
        {
            if (!item.enabled)
            {
                continue;
            }
            levels.Add(item.path);
        }
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        //PlayerSettings.companyName = "cm";
        //PlayerSettings.productName = "WWW";
       // PlayerSettings.applicationIdentifier = "com.cm.WWW";
        string res = BuildPipeline.BuildPlayer(levels.ToArray(), "WWW.apk", BuildTarget.Android, BuildOptions.None);
        if (res.Length>0)
        {
            throw new Exception("BuildPlayer failure:" + res);
        }
    }   	
}
