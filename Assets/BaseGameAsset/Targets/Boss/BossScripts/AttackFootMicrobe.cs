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
    Vector3 LastPose;


    void Start()
    {
        TransformPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        followingFootMicrobe = GetComponent<FollowingFootMicrobe>();
        capsuleCollider = this.gameObject.transform.GetChild(0).GetComponent<CapsuleCollider>();
        LastPose = new Vector3();
    }


    void FixedUpdate()
    {
        time += Time.deltaTime;
        float dis = Vector3.Distance(TransformPlayer.position, transform.position);

        if (dis <= 5 && time>5f)
        {
            animator.SetTrigger("Attack");
            time = 0;
        }
        
        
        if (followingFootMicrobe.GetIsAttack() && dis <= 5f && dis>=2f)
        {
            float speed = 10 - dis;
            speed = speed * Time.deltaTime * .5f;

            LastPose = Vector3.MoveTowards(TransformPlayer.position, transform.position, speed);
            TransformPlayer.position = new Vector3(LastPose.x, TransformPlayer.position.y, LastPose.z);
        }
        
        if (followingFootMicrobe.GetIsAttack() && AttackControl)
        {
            AttackControl = false;
            capsuleCollider.enabled = true;
            RaycastHit hit;
            Vector3 fwd = this.gameObject.transform.GetChild(1).transform.TransformDirection(Vector3.forward);
            Physics.Raycast(this.gameObject.transform.GetChild(1).transform.position,fwd, out hit, 10f);

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
