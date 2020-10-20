using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBossVirus : MonoBehaviour
{
    float timeBoss = 0;
    float sayac;
    float Yieldtime = 5;


  

    void Update()
    {       
            ShootVirusBoss();
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
                Virusbullet.SetActive(true);
                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.tag = "BossVirusBullet";
            }
            else
            {
                sayac = 0;
                Yieldtime = 5;
            }



        }
    }
}
