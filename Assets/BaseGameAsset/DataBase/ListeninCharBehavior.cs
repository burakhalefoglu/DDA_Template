using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeninCharBehavior : MonoBehaviour
{
    GameObject player;
    Character character;

    float PlayerStartHealth;
    float PlayerFinishHealth;
    float PlayerTotalAttackCount;
    float PlayerTotalOnHit;
    float PlayerDeadInformation;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        character = player.GetComponent<Character>();

        StartCoroutine(LateStart(1));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        LateStart();
            
    }
   
    void LateStart()
    {
        PlayerStartHealth = character.GetPlayerHealth();
    }

    public void SetPlayerFinishHealth(float PlayerHealth)
    {
        PlayerFinishHealth = PlayerHealth;
    }

    public void SetPlayerTotalAttackCount(float PlayerTotalAttackCount)
    {
        this.PlayerTotalAttackCount = PlayerTotalAttackCount;
    }
    public void SetPlayerTotalOnHit(float SetPlayerTotalOnHit)
    {
        this.PlayerTotalOnHit = SetPlayerTotalOnHit;
    }
    public void SetPlayerDeadInformation(float SetPlayerDeadInformation)
    {
        this.PlayerDeadInformation = SetPlayerDeadInformation;
    }





    public float GetPlayerStartHealth()
    {
        return PlayerStartHealth;
    }
    public float GetPlayerFinishHealth()
    {
        return PlayerFinishHealth;
    }
    public float GetPlayerTotalAttackCount()
    {
        return PlayerTotalAttackCount;
    }
    public float GetPlayerTotalOnHit()
    {
        return PlayerTotalOnHit;
    }
    public float GetPlayerDeadInformation()
    {
        return PlayerDeadInformation;
    }

}
