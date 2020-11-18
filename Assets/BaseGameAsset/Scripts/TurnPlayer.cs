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
    GameObject go;
    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");



    }


    void Update()
    {
       
            target = go.transform;
            distince = Vector3.Distance(target.position, myTransform.position);
            if (distince < maxdistance)
            {

                transform.rotation = Quaternion.Slerp(myTransform.rotation,
                                                   Quaternion.LookRotation(target.position - myTransform.position),
                                                   rotationSpeed * Time.deltaTime);

            }
        

       
        
    }
}
