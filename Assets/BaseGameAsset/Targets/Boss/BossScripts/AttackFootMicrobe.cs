using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackFootMicrobe : MonoBehaviour
{
    Animator animator;
    Transform TransformPlayer;
    FollowingFootMicrobe followingFootMicrobe;
    float time;
    CapsuleCollider capsuleCollider;
    GameObject MobileInput;
    bool AttackControl=true;

    void Start()
    {
        TransformPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        followingFootMicrobe = GetComponent<FollowingFootMicrobe>();
        capsuleCollider = this.gameObject.transform.GetChild(0).GetComponent<CapsuleCollider>();

    }


    void FixedUpdate()
    {
        time += Time.deltaTime;
        float dis = Vector3.Distance(TransformPlayer.position, transform.position);
        //Debug.Log(dis);

        if (dis <= 5 && time>5f)
        {
            animator.SetTrigger("Attack");
            time = 0;
        }
        
        
        if (followingFootMicrobe.GetIsAttack() && dis <= 5f && dis>=2f)
        {
            float speed = 10 - dis;
            speed = speed * Time.deltaTime * .5f;
            TransformPlayer.position = Vector3.MoveTowards(TransformPlayer.position, transform.position, speed);
        }
        
        if (followingFootMicrobe.GetIsAttack() && AttackControl)
        {
            AttackControl = false;
            capsuleCollider.enabled = true;
            RaycastHit hit;
            Vector3 fwd = this.gameObject.transform.GetChild(1).transform.TransformDirection(Vector3.forward);
            Physics.Raycast(this.gameObject.transform.GetChild(1).transform.position,fwd, out hit, 5f);

            if (hit.collider.gameObject.tag == "Player")
            {
                MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
                for(int i =0; i< MobileInput.transform.childCount; i++)
                {
                    MobileInput.transform.GetChild(i).gameObject.SetActive(false);

                }
                Debug.Log("Çalıştııı");
            
            }

        }
        else if (!followingFootMicrobe.GetIsAttack())
        {
            AttackControl = true;
            capsuleCollider.enabled = false;
            MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
            for (int i = 0; i < MobileInput.transform.childCount; i++)
            {
                MobileInput.transform.GetChild(i).gameObject.SetActive(true);

            }

        }
    }

    public void IsFinishAttack()
    {
        followingFootMicrobe.SetIsAttack(false);
    }

}
