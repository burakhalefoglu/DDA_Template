using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{
    float shootFrequencyTime_Virus = 10;
    float time = 0;


    void Start()
    {

        shootFrequencyTime_Virus = 5 - (5 * PlayerPrefs.GetFloat("DifficultyLevel") / 8);
       
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

            for (int i = 0; i < 10; i++ ){

                Virusbullet.SetActive(true);
                Virusbullet.transform.localPosition = this.gameObject.transform.localPosition;
                Virusbullet.tag = "CuteVirusBullet";
            }

        }

       
    }

    
}
