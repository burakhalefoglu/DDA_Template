using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour
{
    ListeninCharBehavior listeninCharBehavior;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject player = other.gameObject;
            Character character = player.GetComponent<Character>();
            listeninCharBehavior = this.gameObject.transform.GetChild(0).gameObject.GetComponent<ListeninCharBehavior>();


            listeninCharBehavior.SetPlayerFinishHealth((int)character.GetPlayerHealth());


        }
    }
}
