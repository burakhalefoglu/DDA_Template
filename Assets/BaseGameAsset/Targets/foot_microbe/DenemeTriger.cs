using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "FootMicrobeBullet")
        {
            Debug.Log("Çalıştı...");
        }
    }
}
