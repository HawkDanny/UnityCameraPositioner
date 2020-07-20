using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class CameraPositioner : MonoBehaviour
{
    public void PositionCam()
    {
        this.transform.rotation = SceneView.lastActiveSceneView.rotation;
        this.transform.position = SceneView.lastActiveSceneView.camera.transform.position;
    }
}
