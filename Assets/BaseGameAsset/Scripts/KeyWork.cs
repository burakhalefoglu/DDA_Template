using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWork : MonoBehaviour
{
    GameObject LevelFinisher;
    BoxCollider boxCollider;
    void Start()
    {
        LevelFinisher = GameObject.FindGameObjectWithTag("LevelFinisher");
        boxCollider = LevelFinisher.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
       bool charistrigger =other.gameObject.tag == "Player";
        if (charistrigger)
        {
            boxCollider.enabled = true;
            Destroy(this.gameObject);
        }
    }
}
