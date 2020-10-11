using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDatabaseParameters : MonoBehaviour
{
    ListeninCharBehavior listeninCharBehavior;
    float time;
    void Start()
    {
      //Devide id save work........
        int devideid = 0;

        bool IsValidDevideId = PlayerPrefs.HasKey("DevideId");
        CheckSaveSystemInt(IsValidDevideId, devideid, "DevideId");
        listeninCharBehavior = GetComponent<ListeninCharBehavior>();
    }
    private void Update()
    {
        time += Time.deltaTime;
    }

    void CheckSaveSystemInt(bool checkPrefs, int playerPrefKey, string playerPrefName)
    {
        if (!checkPrefs)
        {
            PlayerPrefs.SetInt(playerPrefName, playerPrefKey);

        }
    }


    public int RemainingHealth()
    {
        return (int)(listeninCharBehavior.GetPlayerFinishHealth() / listeninCharBehavior.GetPlayerStartHealth());
    }

    public int AttackSpeed()
    {
        return (int)(listeninCharBehavior.GetPlayerTotalAttackCount()/time);
    }

    public int HitRate()
    {
        return (int)(listeninCharBehavior.GetPlayerTotalAttackCount() / listeninCharBehavior.GetPlayerTotalOnHit());
    }

    public int IsDead()
    {
        return (int)(listeninCharBehavior.GetPlayerDeadInformation());
    }
    public int FinishingTime()
    {
        return (int) time;
    }

}
