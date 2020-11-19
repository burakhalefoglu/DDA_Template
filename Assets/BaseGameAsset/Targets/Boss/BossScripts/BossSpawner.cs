using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject Boss;
    BoxCollider boxCollider;
    bool bossSpawned = false;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && bossSpawned==false)
        {
            Instantiate(Boss, this.gameObject.transform.GetChild(2).transform.position,transform.rotation);

            PlayerPrefs.SetFloat("IsLocStart", 0);
            Vector3 location = new Vector3();
            location = this.gameObject.transform.GetChild(1).transform.position;
            PlayerPrefs.SetFloat("LocX", location.x);
            PlayerPrefs.SetFloat("LocY", location.y);
            PlayerPrefs.SetFloat("LocZ", location.z);

            bossSpawned = true;
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    boxCollider.enabled = false;
    //}


}
