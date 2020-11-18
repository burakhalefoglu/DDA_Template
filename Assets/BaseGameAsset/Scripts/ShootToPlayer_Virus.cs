using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{
    float shootFrequencyTime_Virus = 10;
    float time = 0;

    private Transform myTransform;
    private Transform target;
    GameObject Player;

    [SerializeField]
    float rotationSpeed = 10;

    [SerializeField]
    float FollowingStepCount;
    float distance;

    void Start()
    {
        myTransform = this.gameObject.transform;
        Player = GameObject.FindGameObjectWithTag("Player");
        shootFrequencyTime_Virus = Random.Range(3, 10);
       
    }


    void Update()
    {
        target = Player.transform;
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                         Quaternion.LookRotation(target.position - myTransform.position),
                                         rotationSpeed * Time.deltaTime);

        distance = Vector3.Distance(target.position, myTransform.position);

        if (distance > 10)
        {
            follow();
        }


        if (distance <= 10)
        {
            ShootPlayer();
        }


    }

    void ShootPlayer()
    {
        time += Time.deltaTime;
        GameObject Virusbullet = ObjectPooling.SharedInstance.GetPooledVirusBullet();

        if (time > shootFrequencyTime_Virus)
        {
            time = 0;

                Virusbullet.SetActive(true);
                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.tag = "CuteVirusBullet";

        }

       
    }

    void follow()
    {

        myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

    }

}
