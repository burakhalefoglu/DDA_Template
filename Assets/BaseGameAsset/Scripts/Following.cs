using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    [SerializeField]
    float maxdistance;

    [SerializeField]
    float FollowingStepCount;
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
        if (Time.frameCount % 3 == 0)
        {
            target = go.transform;
            follow();

        }




    }

    void follow()
    {

        if (Vector3.Distance(target.localPosition, myTransform.localPosition) < maxdistance)
        {

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.localPosition - myTransform.localPosition),
                                               rotationSpeed * Time.deltaTime);

            myTransform.localPosition = Vector3.MoveTowards(transform.localPosition, target.transform.localPosition, FollowingStepCount);

        }

    }


}
