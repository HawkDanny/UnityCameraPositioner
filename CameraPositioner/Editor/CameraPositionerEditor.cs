using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraPositioner))]
public class CameraPositionerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CameraPositioner camPos = (CameraPositioner)target;
        if (GUILayout.Button("Position Camera"))
        {
            camPos.PositionCam();
        }
    }
}
