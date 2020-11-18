using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{
    float shootFrequencyTime_Virus = 10;
    float time = 0;


    void Start()
    {

        shootFrequencyTime_Virus = Random.Range(3, 10);
       
    }


    void Update()
    {
      
            ShootPlayer();

    }

    void ShootPlayer()
    {
        time += Time.deltaTime;
        GameObject Virusbullet = ObjectPooling.SharedInstance.GetPooledVirusBullet();

        if (time > shootFrequencyTime_Virus)
        {
            time = 0;

                Virusbullet.SetActive(true);
                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.tag = "CuteVirusBullet";

        }

       
    }

    
}
