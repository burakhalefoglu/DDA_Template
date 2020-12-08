using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWork : MonoBehaviour
{
    GameObject LevelFinisher;
    void Start()
    {
        LevelFinisher = GameObject.FindGameObjectWithTag("LevelFinisher");
        LevelFinisher.GetComponent<LevelFinisher>().GetAllDataAndFinish();
        GetComponent<AudioSource>().Play();
        Destroy(this.gameObject, 2f);
    }

   

}
