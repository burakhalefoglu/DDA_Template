using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    int deneme=0;
    void Start()
    {
        denemem();
    }

   void denemem()
    {
        deneme2();
        deneme = 3;
        Debug.Log(deneme);

    }
    void deneme2()
    {
        deneme = 2;
        Debug.Log(deneme);

    }
}
