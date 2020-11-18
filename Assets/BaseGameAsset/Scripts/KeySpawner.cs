using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject Key;
    Target target;

    bool IsSpawned = false;
    private void Start()
    {
        target = GetComponent<Target>();
    }

    private void Update()
    {

        if (target.GetCurrentHealth() <= 1 && !IsSpawned)
        {
            SpawnKey();
            IsSpawned = true;
        }
    }



    void SpawnKey()
    {
        Instantiate(Key, transform.position, transform.rotation);

    }
}
