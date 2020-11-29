using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWork : MonoBehaviour
{
    GameObject LevelFinisher;
    void Start()
    {
        LevelFinisher = GameObject.FindGameObjectWithTag("LevelFinisher");

    }

    private void OnTriggerEnter(Collider other)
    {
       bool charistrigger =other.gameObject.tag == "Player";
        if (charistrigger)
        {
            LevelFinisher.GetComponent<LevelFinisher>().GetAllDataAndFinish();
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject,1f);


        }
    }

}
