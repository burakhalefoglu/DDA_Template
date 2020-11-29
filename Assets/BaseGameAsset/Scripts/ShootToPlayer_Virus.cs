using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{

    GameObject Player;

    [SerializeField]
    float rotationSpeed = 10;

 
    float FollowingStepCount;
    float distance;
    float time = 0;
    float Attacktime = 0;

    Animator animator;
    GameObject [] CuteVirusBullet;

    void Start()
    {
        FollowingStepCount = PlayerPrefs.GetFloat("Walk_Speed");
        Player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        CuteVirusBullet = GameObject.FindGameObjectsWithTag("CuteVirusBullet");
    }


    void Update()
    {
      
        transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.LookRotation(Player.transform.position - transform.position),
                                                rotationSpeed * Time.deltaTime);




        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance > 75f)
        {
            if (animator.GetBool("attackfollow") == true)
            {
                animator.SetBool("attackfollow", false);
                animator.SetBool("attack", false);

            }
        }


        if (distance > 4f && distance < 60f)
        {
            time += Time.deltaTime;
            if (time <= 3f)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowingStepCount);
            }
            else if (time > 3f && time<5f)
            {
                if (animator.GetBool("attackfollow") == true)
                {
                    animator.SetBool("attackfollow", false);
                    animator.SetBool("attack", false);

                }
                this.gameObject.transform.GetChild(5).gameObject.SetActive(true);
            }
            else if (time > 5f)
            {
                time = 0;
                this.gameObject.transform.GetChild(5).gameObject.SetActive(false);
                if (animator.GetBool("attackfollow") == false)
                {
                    animator.SetBool("attackfollow", true);
                    animator.SetBool("attack", false);
                }

            }

        }

        
        if (distance <= 4)
        {
            Attacktime += Time.deltaTime;

            if (Attacktime > PlayerPrefs.GetFloat("Virus_Attack_Density"))
            {
                    animator.SetTrigger("attack");
            }
          
           
        }


    }


    public void AttackStart()
    {
        for(int i =0; i< CuteVirusBullet.Length; i++)
        {
            CuteVirusBullet[i].GetComponent<BoxCollider>().enabled = true;
        }
    }


    public void AttackStop()
    {
        for (int i = 0; i < CuteVirusBullet.Length; i++)
        {
            CuteVirusBullet[i].GetComponent<BoxCollider>().enabled = false;
        }
    }

}
