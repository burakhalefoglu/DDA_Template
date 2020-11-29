using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingFootMicrobe : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float rotationSpeed;

    [SerializeField]
    float maxdistance;

    float FollowingStepCount = 0.1f;

    bool IsAttack = false;

    Animator animator;

    Quaternion LastRot;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        FollowingStepCount = PlayerPrefs.GetFloat("Walk_Speed");
        animator = GetComponent<Animator>();
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        LastRot = new Quaternion();


    }
    void Update()
    {
        LastRot= Quaternion.Slerp(myTransform.rotation,
                                              Quaternion.LookRotation(target.position - myTransform.position),
                                              rotationSpeed * Time.deltaTime);
        myTransform.rotation = new Quaternion(transform.rotation.x, LastRot.y, LastRot.z,1);
        if (!IsAttack)
        {
            follow();
        }
       

    }

    void follow()
    {

        Debug.DrawLine(target.position, myTransform.position, Color.red);
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
