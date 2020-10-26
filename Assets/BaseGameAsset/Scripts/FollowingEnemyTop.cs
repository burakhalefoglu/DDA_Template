using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class FollowingEnemyTop : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    float maxdistance = 30;
    float FollowingStepCount = 0.01f;

    Animator animator;

    EnemyTopAttack enemyTopAttack;
    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        animator = GetComponent<Animator>();
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        enemyTopAttack = this.gameObject.GetComponent<EnemyTopAttack>();
        target = go.transform;



    }
    void Update()
    {
        if(!enemyTopAttack.GetIsChar())
        follow();

    }

    void follow()
    {

        Debug.DrawLine(target.position, myTransform.position, Color.red);
        float distance = Vector3.Distance(target.position, myTransform.position);
        if (distance < maxdistance)
        {
            animator.SetBool("IsJump", true);
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(target.position - myTransform.position),
                                               rotationSpeed * Time.deltaTime);

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

        }
        else
        {
            animator.SetBool("IsJump", false);
        }

    }


}
