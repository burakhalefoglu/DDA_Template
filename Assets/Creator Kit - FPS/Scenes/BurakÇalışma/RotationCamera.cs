﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{
  private Vector3 firstpoint; //change type on Vector3
  private Vector3 secondpoint;
  private float xAngle; //angle for axes x for rotation
  private float yAngle;
  private float xAngTemp = 0.0f; //temp variable for angle
  private float yAngTemp  = 0.0f;
  void Start()
    {
        //Initialization our angles of camera
        xAngle = 0.0f;
        yAngle = 0.0f;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }
    void Update()
    {
        //Check count touches
        if (Input.touchCount > 0)
        {
            //Touch began, save position
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                firstpoint = Input.GetTouch(0).position;
                xAngTemp = xAngle;
                yAngTemp = yAngle;
            }
            //Move finger by screen
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                secondpoint = Input.GetTouch(0).position;
                //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
                xAngle =(float)( xAngTemp + (secondpoint.x - firstpoint.x) * 180.0 / Screen.width);
                yAngle = (float)(yAngTemp - (secondpoint.y - firstpoint.y) * 90.0 / Screen.height);
                //Rotate camera
                this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
            }
        }
    }
}
