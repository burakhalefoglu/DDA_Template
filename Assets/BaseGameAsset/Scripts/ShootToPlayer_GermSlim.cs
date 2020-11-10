using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer_GermSlim : MonoBehaviour
{

    GameObject Target;
    [SerializeField]
    float shootFrequencyTime = 1;
    float time = 0;

   
    void Start()
    {
       
        Target = GameObject.FindGameObjectWithTag("Player");
        shootFrequencyTime = 5 - (5 * PlayerPrefs.GetFloat("DifficultyLevel") / 10);

    }


    void Update()
    {
     
            ShootPlayer();

    }
  void ShootPlayer()
    {
        time += Time.deltaTime;
        GameObject bullet = ObjectPooling.SharedInstance.GetPooledObject();
        if (time > shootFrequencyTime)
        {
            time = 0;
            bullet.SetActive(true);
            bullet.transform.localPosition = this.gameObject.transform.localPosition;
            bullet.tag = "GermSlimeBullet";
        }
    }
}
