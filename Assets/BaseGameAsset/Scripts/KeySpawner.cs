using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject Key;


    public void SpawnKey()
    {
        Instantiate(Key, transform.position, transform.rotation);

    }
}
