using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachingTheEnemy : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    [SerializeField]
    float maxdistance;

    [SerializeField]
    float FollowingStepCount;

    [SerializeField]
    float MaxApproachDistance;

    float dist;
    float timeFollow;
    float timeAttack;
    Vector3 LastPose;

    ShootingBossFly shootingBossFly;
    GameObject go;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
       go = GameObject.FindGameObjectWithTag("Player");
        shootingBossFly=GetComponent<ShootingBossFly>();
        LastPose = new Vector3();
     
    }

    void Update()
    {
        target = go.transform;
        timeFollow += Time.deltaTime;
        timeAttack += Time.deltaTime;

        TurnToPlayer();

        if (CalculateDistiance() < MaxApproachDistance && timeAttack>2)
        {
            timeAttack = 0;
            shootingBossFly.ShootPlayer();

        }


        if (timeFollow > 0.05f)
        {
            timeFollow = 0;
            if (CalculateDistiance() > MaxApproachDistance)
            {

                follow();

            }

        }


    }

    void TurnToPlayer()
    {
        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                   Quaternion.LookRotation(target.position - myTransform.position),
                                   rotationSpeed * Time.deltaTime);
        }
    }
    void follow()
    {
        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {
            LastPose= Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);
            myTransform.position = new Vector3(LastPose.x, transform.position.y, LastPose.z);

        }

    }

   float CalculateDistiance()
    {
        dist = Vector3.Distance(target.position, transform.position);
        return dist;
    }

}
