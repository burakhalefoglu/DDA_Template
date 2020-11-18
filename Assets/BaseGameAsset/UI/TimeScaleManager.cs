using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleManager : MonoBehaviour
{

    [SerializeField]
    float timescale;
    
    void Start()
    {
        Time.timeScale = timescale;
    }

  
}
