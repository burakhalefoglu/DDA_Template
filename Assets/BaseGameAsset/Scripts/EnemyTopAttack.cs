using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class EnemyTopAttack : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform transform;
    float strength = 10f;
    Animator animator;
    bool IsChar=false;
    float time=0f;
    private void Start()
    {
        animator = GetComponent<Animator>();
        transform = gameObject.transform;
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "Player")
        {
            IsChar = true;
        }
    }

    private void FixedUpdate()
    {
        if (IsChar)
        {
          
            animator.SetBool("IsTouch", true);
           // rigidbody.AddForce(-transform.forward * strength);
            rigidbody.AddForce(-transform.forward * strength, ForceMode.Force);
        }
    }

    private void Update()
    {

        if (IsChar)
        {
            time += Time.deltaTime;
            if (time < 1.5f)
            {
                return;

            }
            animator.SetBool("IsTouch", false);
            IsChar = false;
            time = 0;
            rigidbody.isKinematic = true;

        }

        if (rigidbody.isKinematic)
        {
            rigidbody.isKinematic = false;
        }
    }

    public bool GetIsChar()
    {
        return IsChar;
    }

}
