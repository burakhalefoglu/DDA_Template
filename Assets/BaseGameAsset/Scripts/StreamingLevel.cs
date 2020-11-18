using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamingLevel : MonoBehaviour
{

    GameObject Player;
    float dist;
    GameObject child;
    float time = 0;

    float MaxDist =150;
    float childcount;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        childcount = this.gameObject.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1f)
        {
            time = 0;
            CalculateDistanceOpenCloseObject();

        }

    }

   void CalculateDistanceOpenCloseObject()
    {
        for (int i=0; i< childcount; i++)
        {
            child = this.gameObject.transform.GetChild(i).gameObject;
            dist = Vector3.Distance(child.transform.position, Player.transform.position);
            if (dist > MaxDist)
            {
                child.SetActive(false);
            }
            else
            {
                child.SetActive(true);
            }
        }
    }
}
