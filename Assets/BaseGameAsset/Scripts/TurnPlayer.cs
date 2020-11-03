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

        Debug.DrawLine(target.position, myTransform.position, Color.red);
        distince = Vector3.Distance(target.position, myTransform.position);
        if (distince < maxdistance)
        {

            transform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.position - myTransform.position),
                                               rotationSpeed * Time.deltaTime);
           

        }
    }
}
