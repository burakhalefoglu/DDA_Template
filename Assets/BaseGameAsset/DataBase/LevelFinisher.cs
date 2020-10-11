using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour
{
    ListeninCharBehavior listeninCharBehavior;
    DataAccess dataAccess;
    BoxCollider boxCollider;
    GameObject FinishUI;
    private void Awake()
    {
        FinishUI = GameObject.FindGameObjectWithTag("SucceesLevel");
        boxCollider = this.gameObject.GetComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject player = other.gameObject;
            Character character = player.GetComponent<Character>();
            listeninCharBehavior = this.gameObject.transform.GetChild(0).gameObject.GetComponent<ListeninCharBehavior>();
            dataAccess = this.gameObject.transform.GetChild(0).gameObject.GetComponent<DataAccess>();

            listeninCharBehavior.SetPlayerFinishHealth((int)character.GetPlayerHealth());
            listeninCharBehavior.SetPlayerTotalAttackCount((int)character.GetTotalAttack());
            listeninCharBehavior.SetPlayerTotalOnHit((int)character.GetTotalHit());
            listeninCharBehavior.SetPlayerDeadInformation((int)character.GetPlayerDeadInformation());
            dataAccess.verileriekle();
            FinishUI.SetActive(true);

        }
    }


}
