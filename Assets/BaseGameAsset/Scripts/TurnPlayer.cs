using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPlayer : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float maxdistance=20;
    [SerializeField]
    float rotationSpeed =10;
    Quaternion rotation;
    float distince;
    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;


    }


    void Update()
    {
        if (Time.frameCount % 3 == 0)
        {
            distince = Vector3.Distance(target.localPosition, myTransform.localPosition);
            if (distince < maxdistance)
            {

                transform.rotation = Quaternion.Slerp(myTransform.rotation,
                                                   Quaternion.LookRotation(target.localPosition - myTransform.localPosition),
                                                   rotationSpeed * Time.deltaTime);

            }
        }

       
        
    }
}
