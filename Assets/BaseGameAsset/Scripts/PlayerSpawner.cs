using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void Awake()
    {
        if (PlayerPrefs.GetFloat("IsLocStart") != 0)
        {

            Instantiate(Player, new Vector3(PlayerPrefs.GetFloat("LocX"), PlayerPrefs.GetFloat("LocY"), PlayerPrefs.GetFloat("LocZ")), transform.rotation);

        }
        else
        {
            Instantiate(Player, transform.position, transform.rotation);

        }
    }

}
