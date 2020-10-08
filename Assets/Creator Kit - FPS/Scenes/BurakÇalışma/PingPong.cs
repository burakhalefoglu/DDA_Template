using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    void Update()
    {
        // Set the x position to loop between 0 and 3
        transform.position = new Vector3(Mathf.PingPong(Time.time,.1f), transform.position.y, transform.position.z);
    }
}
