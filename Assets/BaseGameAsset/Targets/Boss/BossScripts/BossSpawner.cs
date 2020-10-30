using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject Boss;
    BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        bool control= other.gameObject.tag == "Player";
        if (control)
        {
            Instantiate(Boss, this.gameObject.transform);

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        boxCollider.enabled = false;
    }



}
