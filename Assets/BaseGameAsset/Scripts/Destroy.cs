using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Target target;
    bool Killme = false;
    private void Update()
    {
        if (Killme)
        {
            target.killyourself();

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        target = GetComponent<Target>();

        if (collision.gameObject.tag == "Player")
        {
            Killme = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        target = GetComponent<Target>();

        if (other.gameObject.tag == "Player")
        {
            Killme = true;
        }
    }
}
