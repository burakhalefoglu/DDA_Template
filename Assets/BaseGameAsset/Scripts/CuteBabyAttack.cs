using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuteBabyAttack : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    float maxdistance = 30;
    float FollowingStepCount = 0.01f;
    float time = 3;
    float timeToCollision = 0;
    float distance;
    BoxCollider boxCollider;
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        myTransform = transform;
        boxCollider = GameObject.FindGameObjectWithTag("CuteBabyBullet").GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 3 == 0)
            distance = Vector3.Distance(target.localPosition, myTransform.localPosition);


        if (distance < maxdistance && distance > 9f)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.localPosition - myTransform.localPosition),
                                               rotationSpeed * Time.deltaTime);

            myTransform.localPosition = Vector3.MoveTowards(transform.localPosition, target.transform.localPosition, FollowingStepCount);
            boxCollider.enabled = false;
        }

        else if (distance < 10f)
        {
            time += Time.deltaTime;
            if (time > 3f)
            {
                time = 0;
                animator.SetTrigger("CuteBabyAttack");
                boxCollider.enabled = true;
            }


        }

        if (boxCollider.enabled)
        {
            timeToCollision += Time.deltaTime;
            if (timeToCollision > 1.5f)
            {
                timeToCollision = 0;
                boxCollider.enabled = false;
            }
        }
    }
}
