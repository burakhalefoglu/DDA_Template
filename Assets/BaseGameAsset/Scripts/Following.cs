using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float maxdistance = 20;
    [SerializeField]
    float rotationSpeed = 10;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxdistance = 200;
    }
    void Update()
    {

        Debug.DrawLine(target.position, myTransform.position, Color.red);
        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.position - myTransform.position),
                                               rotationSpeed * Time.deltaTime);

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.03f);

        }

       

        
    }



}
