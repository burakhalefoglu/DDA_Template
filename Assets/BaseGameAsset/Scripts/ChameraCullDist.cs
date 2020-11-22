using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChameraCullDist : MonoBehaviour
{
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        float[] distances = new float[32];
        distances[10] = 1000;
        camera.layerCullDistances = distances;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
