using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{

    float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > .5f)
        {
            time = 0;
            gameObject.SetActive(false);
        }
    }
}
