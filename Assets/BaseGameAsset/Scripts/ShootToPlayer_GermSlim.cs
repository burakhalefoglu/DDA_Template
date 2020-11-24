using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_GermSlim : MonoBehaviour
{

    private Transform myTransform;
    private Transform target;
    GameObject Player;

    [SerializeField]
    float rotationSpeed = 10;

    [SerializeField]
    float FollowingStepCount;
    float shootFrequencyTime;
    float time = 0;
    float distance;
   
    void Start()
    {
        myTransform = this.gameObject.transform;
        Player = GameObject.FindGameObjectWithTag("Player");
        shootFrequencyTime = Random.Range(5,9);

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

    void follow()
    {

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

    }
    

    void ShootPlayer()
    {
        time += Time.deltaTime;
        GameObject bullet = ObjectPooling.SharedInstance.GetPooledObject();
        if (time > shootFrequencyTime)
        {
            time = 0;
            bullet.SetActive(true);
            bullet.transform.position = this.gameObject.transform.position;
            bullet.tag = "GermSlimeBullet";
        }
    }
}
