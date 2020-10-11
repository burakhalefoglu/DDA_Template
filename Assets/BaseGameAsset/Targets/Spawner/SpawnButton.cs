using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(TargetSpawner))]
public class SpawnButton : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        TargetSpawner myScript = (TargetSpawner)target;

        if (GUILayout.Button("Generate GameObject"))
        {
            myScript.BuildObject();
        }
    }
}