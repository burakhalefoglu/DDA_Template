using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{
    GameObject Target;
    float shootFrequencyTime_Virus = 1;
    float time = 0;
    float timeBoss=0;
    bool IsBoss=false;
    float sayac;
    float Yieldtime = 5;

    void Start()
    {

        Target = GameObject.FindGameObjectWithTag("Player");
        shootFrequencyTime_Virus = 5 - (5 * PlayerPrefs.GetFloat("DifficultyLevel") / 8);
        if(this.gameObject.tag== "BossVirus")
        {
            IsBoss = true;
        }
    }


    void Update()
    {
        if (IsBoss)
        {
            ShootVirusBoss();
            return;
        }
        ShootPlayer();
       
    }
    void ShootPlayer()
    {
        time += Time.deltaTime;
        GameObject Virusbullet = ObjectPooling.SharedInstance.GetPooledVirusBullet();

        if (time > shootFrequencyTime_Virus)
        {
            time = 0;

            for (int i = 0; i < 10; i++ ){

                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.transform.rotation = this.gameObject.transform.rotation;
                Virusbullet.SetActive(true);
            }

        }

       
    }

    void ShootVirusBoss()
    {
        timeBoss += Time.deltaTime;
        GameObject Virusbullet = ObjectPooling.SharedInstance.GetPooledVirusBullet();

        if (timeBoss > Yieldtime)
        {
            timeBoss = 0;
            if (sayac < 5)
            {
                sayac += 1;
                Yieldtime = 1;
                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.transform.rotation = this.gameObject.transform.rotation;
                Virusbullet.SetActive(true);
            }
            else
            {
                sayac = 0;
                Yieldtime = 5;
            }
               
            

        }
    }
}
