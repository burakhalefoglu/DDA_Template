using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    void Update()
    {
        if (Time.frameCount % 3 == 0)
        transform.position = new Vector3(Mathf.PingPong(Time.time,.1f), transform.position.y, transform.position.z);
    }
}
