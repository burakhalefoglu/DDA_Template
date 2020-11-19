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

        if (target.GetCurrentHealth() <= 5 && !IsSpawned)
        {
            SpawnKey();
        }
    }



    void SpawnKey()
    {
        Vector3 SpawnPos = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
        Instantiate(Key, SpawnPos, transform.rotation);
        IsSpawned = true;
    }
}
