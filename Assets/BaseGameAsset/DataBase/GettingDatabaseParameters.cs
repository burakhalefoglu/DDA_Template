using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDatabaseParameters : MonoBehaviour
{
    float time;
    Character player;
    void Start()
    {
      //Devide id save work........
        int devideid = 0;

        bool IsValidDevideId = PlayerPrefs.HasKey("DevideId");
        CheckSaveSystemInt(IsValidDevideId, devideid, "DevideId");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
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


    public float RemainingHealth()
    {
        return player.GetPlayerHealth();
    }

    public float AttackSpeed()
    {
        return (player.GetTotalAttack()/time);
    }

    public float HitRate()
    {
        return (player.GetTotalHit()/player.GetTotalAttack());
    }

    public int IsDead()
    {
        return PlayerPrefs.GetInt("IsDead");

    }
    public float FinishingTime()
    {
        return time;
    }

}
