using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_Virus : MonoBehaviour
{
    GameObject Target;
    [SerializeField]
    float shootFrequencyTime_Virus = 1;
    float time = 0;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
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

                Virusbullet.transform.position = this.gameObject.transform.position;
                Virusbullet.transform.rotation = this.gameObject.transform.rotation;
                Virusbullet.SetActive(true);
            }

        }

       
    }
}
