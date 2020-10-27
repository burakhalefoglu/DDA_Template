using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingFootMicrobe : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed = 10;

    float maxdistance = 30;
    float FollowingStepCount = 0.05f;
    bool IsAttack = false;

    Animator animator;
    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        
        animator = GetComponent<Animator>();
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;



    }
    void Update()
    {
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                              Quaternion.LookRotation(target.position - myTransform.position),
                                              rotationSpeed * Time.deltaTime);
        if (!IsAttack)
        {
            follow();
        }
       

    }

    void follow()
    {

        //Debug.DrawLine(target.position, myTransform.position, Color.red);
        float distance = Vector3.Distance(target.position, myTransform.position);

        if (distance < maxdistance && distance > 5) 
        {
            animator.SetBool("Runing", true);

            myTransform.position = Vector3.MoveTowards(transform.position, target.transform.position, FollowingStepCount);

        }
        else
        {
            animator.SetBool("Runing", false);
        }

    }

    public void SetIsAttack(bool IsAttack)
    {
        this.IsAttack = IsAttack;
    }

    public bool GetIsAttack()
    {
        return this.IsAttack;
    }

    public void SetAttackForStart()
    {
        this.IsAttack = true;

    }

}
