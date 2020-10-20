using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachingTheEnemy : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    float maxdistance = 5;
    float FollowingStepCount = 0.1f;
    float dist;
    float timeFollow;
    float timeAttack;


    ShootingBossFly shootingBossFly;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        shootingBossFly=GetComponent<ShootingBossFly>();

        target = go.transform;

        maxdistance = 200;


    }

    void Update()
    {
        timeFollow += Time.deltaTime;
        timeAttack += Time.deltaTime;

        TurnToPlayer();

        if (CalculateDistiance() < 12 && timeAttack>3)
        {
            timeAttack = 0;
            shootingBossFly.ShootPlayer();

        }


        if (timeFollow > 0.05f)
        {
            timeFollow = 0;
            if (CalculateDistiance() > 8)
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
        Debug.DrawLine(target.position, myTransform.position, Color.red);
        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

        }

    }

   float CalculateDistiance()
    {
        dist = Vector3.Distance(target.position, transform.position);

        return dist;
    }

}
