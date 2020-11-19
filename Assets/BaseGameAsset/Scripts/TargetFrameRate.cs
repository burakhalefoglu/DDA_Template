using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour
{
    private void Awake()
    {
       //PlayerPrefs.DeleteAll();
        Application.targetFrameRate = 30;
    }

  
}
