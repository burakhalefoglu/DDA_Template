using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemyTop : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    float maxdistance = 50;
    float FollowingStepCount;

    Animator animator;

    EnemyTopAttack enemyTopAttack;

    GameObject go;
    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        animator = GetComponent<Animator>();
        go  = GameObject.FindGameObjectWithTag("Player");
        enemyTopAttack = this.gameObject.GetComponent<EnemyTopAttack>();
        FollowingStepCount = PlayerPrefs.GetFloat("Walk_Speed");


    }
    void Update()
    {
        target = go.transform;
        if (!enemyTopAttack.GetIsChar())
        follow();

    }

    void follow()
    {

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
