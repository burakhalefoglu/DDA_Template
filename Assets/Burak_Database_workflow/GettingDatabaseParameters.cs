using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDatabaseParameters : MonoBehaviour
{

    void Start()
    {
      //Devide id save work........
        devideid = 0;

        bool IsValidDevideId = PlayerPrefs.HasKey("DevideId");
        CheckSaveSystemInt(IsValidDevideId, devideid, "DevideId");

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
        return 0;
    }
}
