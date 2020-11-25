using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;
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
    Joystick joystick;
    int touchİndex;

    void Start()
    {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
        joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();

    }

    void Update()
    {
        

        if (Input.touchCount ==1)
        {
            Debug.Log(Input.GetTouch(0).fingerId);

            if (joystick.GetjoystickHeld() == false)
            {
                ControlTouchPos(0);

                if (Input.GetTouch(0).fingerId == 0)
                {
                    touchİndex = 0;
                }
                else if (Input.GetTouch(0).fingerId == 1)
                {
                    touchİndex = 1;
                }
            }
            else if (joystick.GetjoystickHeld() == true)
            {
                if (Input.GetTouch(0).fingerId == 0)
                {
                    touchİndex = 1;
                }
                else if (Input.GetTouch(0).fingerId == 1)
                {
                    touchİndex = 0;
                }
            }

        }

        else if(Input.touchCount == 2)
        { 
               ControlTouchPos(touchİndex);
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
            rotationClamp = Quaternion.Euler(ClampAngel, xAngle, 4.5f);


            this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotationClamp.eulerAngles.y, transform.rotation.eulerAngles.z);
            this.gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(rotationClamp.eulerAngles.x,transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        }
    }



    void ControlTouchPos(int finger)
    {

        CheckingPoint = Input.GetTouch(finger).position;
        float PointRate;
        PointRate = CheckingPoint.x / Screen.width;
        if (PointRate > 0.3f/* && PointRate < 0.75f*/)
        {
            RotateCamera(finger);


        }
    }
}
