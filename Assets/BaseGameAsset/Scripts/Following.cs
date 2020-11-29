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

    float FollowingStepCount;
    GameObject go;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");

        FollowingStepCount = PlayerPrefs.GetFloat("Walk_Speed");


    }
    void Update()
    {

            target = go.transform;
            follow();

    }

    void follow()
    {

        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.position - myTransform.position),
                                               rotationSpeed * Time.deltaTime);

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

        }

    }


}
