using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingEventCamera : MonoBehaviour
{
    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;

    }
}
