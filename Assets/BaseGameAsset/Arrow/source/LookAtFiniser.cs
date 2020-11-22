using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtFiniser : MonoBehaviour
{


     Transform target;
    Vector3 relativePos;
    Quaternion LastRot;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("LevelFinisher").transform;
    }


    void Update()
    {
        LastRot = Quaternion.Slerp(transform.rotation,
                                             Quaternion.LookRotation(target.position - transform.position),
                                             10 * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, LastRot.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
