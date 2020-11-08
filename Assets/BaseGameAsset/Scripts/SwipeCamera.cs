using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCamera : MonoBehaviour
{
    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;

    Vector3 CheckingPoint;
    Quaternion rotationClamp;
    float ClampAngel;


    void Start()
    {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
    }

    void Update()
    {
          

        if (Input.touchCount > 0)
        {
             ControlTouchPos(Input.touchCount-1);

        }

    }



    void RotateCamera(int touchfinger)
    {
        if (Input.GetTouch(touchfinger).phase == TouchPhase.Began)
        {

            FirstPoint = Input.GetTouch(touchfinger).position;
            xAngleTemp = xAngle;
            yAngleTemp = yAngle;

        }
        if (Input.GetTouch(touchfinger).phase == TouchPhase.Moved)
        {

            SecondPoint = Input.GetTouch(touchfinger).position;
            xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
            yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
            ClampAngel = -yAngle;
            ClampAngel = Mathf.Clamp(ClampAngel, -60, 60);
            rotationClamp = Quaternion.Euler(ClampAngel, xAngle, 0.1f);
            this.transform.rotation = Quaternion.Euler(rotationClamp.eulerAngles);

        }
    }



    void ControlTouchPos(int finger)
    {

        CheckingPoint = Input.GetTouch(finger).position;
        float PointRate;
        PointRate = CheckingPoint.x / Screen.width;
        if (PointRate > 0.3f && PointRate < 0.75f)
        {
            RotateCamera(finger);


        }
    }
}
