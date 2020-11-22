using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{


    void Start()
    {  

        SaveVirusParams();
        SaveGermSlimParams();
        SaveGermSpikeParams();

        SaveCuteMushyParams();
        SaveCuteBacteriumParams();
        SaveHelloKittyParams();

        SavePlayerParams();

        SaveOtherParams();
        SaveLocationparams();
        KeyGenerator();
        PlayerPrefs.Save();
       

    }

    void KeyGenerator()
    {
        bool IsDevideId;
        float DevideId = Random.Range(111111111, 999999999);
        IsDevideId = PlayerPrefs.HasKey("GermSlime_Health");
        CheckSaveSystemInt(IsDevideId, (int)DevideId, "DevideId");
    }

    void CheckSaveSystemFloat(bool checkPrefs, float playerPrefKey, string playerPrefName )
    {
        if (!checkPrefs)
        {
            PlayerPrefs.SetFloat(playerPrefName, playerPrefKey);
        }
    }

    void CheckSaveSystemString(bool checkPrefs, string playerPrefKey, string playerPrefName)
    {
        if (!checkPrefs)
        {
            PlayerPrefs.SetString(playerPrefName, playerPrefKey);
        }
    }

    void CheckSaveSystemInt(bool checkPrefs, int playerPrefKey, string playerPrefName)
    {
        if (!checkPrefs)
        {
            PlayerPrefs.SetInt(playerPrefName, playerPrefKey);
        }
    }


    void SaveVirusParams()
    {
        bool IsValidVirus_Health;
        bool IsValidVirus_Attack;
        bool IsValidVırus_Density;
        bool IsValidVırus_Level;

        IsValidVirus_Health = PlayerPrefs.HasKey("Virus_Health");
        CheckSaveSystemFloat(IsValidVirus_Health, 10, "Virus_Health");

        IsValidVirus_Attack = PlayerPrefs.HasKey("Virus_Attack");
        CheckSaveSystemFloat(IsValidVirus_Attack, 5, "Virus_Attack");

        IsValidVırus_Density = PlayerPrefs.HasKey("Vırus_Density");
        CheckSaveSystemInt(IsValidVırus_Density, 1, "Vırus_Density");

        IsValidVırus_Level = PlayerPrefs.HasKey("Vırus_Level");
        CheckSaveSystemFloat(IsValidVırus_Level, 1, "Vırus_Level");


    }

    void SaveGermSlimParams()
    {
        bool IsValidGermSlime_Health;
        bool IsValidGermSlime_Attack;
        bool IsValidGermSlime_Density;
        bool IsValidGermSlime_Level;

        IsValidGermSlime_Health = PlayerPrefs.HasKey("GermSlime_Health");
        CheckSaveSystemFloat(IsValidGermSlime_Health, 10, "GermSlime_Health");

        IsValidGermSlime_Attack = PlayerPrefs.HasKey("GermSlime_Attack");
        CheckSaveSystemFloat(IsValidGermSlime_Attack, 10, "GermSlime_Attack");

        IsValidGermSlime_Density = PlayerPrefs.HasKey("GermSlime_Density");
        CheckSaveSystemInt(IsValidGermSlime_Density, 1, "GermSlime_Density");

        IsValidGermSlime_Level = PlayerPrefs.HasKey("GermSlime_Level");
        CheckSaveSystemFloat(IsValidGermSlime_Level, 1, "GermSlime_Level");



    }

    void SaveGermSpikeParams()
    {
        bool IsValidGermSpike_Health;
        bool IsValidGermSpike_Density;

        IsValidGermSpike_Health = PlayerPrefs.HasKey("GermSpike_Health");
        CheckSaveSystemFloat(IsValidGermSpike_Health, 10, "GermSpike_Health");

        IsValidGermSpike_Density = PlayerPrefs.HasKey("GermSpike_Density");
        CheckSaveSystemInt(IsValidGermSpike_Density, 1, "GermSpike_Density");


    }

    void SaveCuteMushyParams()
    {
        bool IsValidCuteMushy_Density;

        IsValidCuteMushy_Density = PlayerPrefs.HasKey("CuteMushy_Density");
        CheckSaveSystemInt(IsValidCuteMushy_Density, 1, "CuteMushy_Density");
    }

    void SaveCuteBacteriumParams()
    {
        bool IsValidCuteBacterium_Density;

        IsValidCuteBacterium_Density = PlayerPrefs.HasKey("CuteBacterium_Density");
        CheckSaveSystemInt(IsValidCuteBacterium_Density, 10, "CuteBacterium_Density");
    }


    void SaveHelloKittyParams()
    {
        bool IsValidHelloKitty_Density;

        IsValidHelloKitty_Density = PlayerPrefs.HasKey("HelloKitty_Density");
        CheckSaveSystemInt(IsValidHelloKitty_Density, 1, "HelloKitty_Density");
    }
    
    void SaveEnemyTopParams()
    {
        bool IsValidEnemyTop_Density;

        IsValidEnemyTop_Density = PlayerPrefs.HasKey("EnemyTop_Density");
        CheckSaveSystemInt(IsValidEnemyTop_Density, 1, "EnemyTop_Density");
    }

    void SaveCuteBabyParams()
    {
        bool IsValidCuteBaby_Density;
        bool IsValidCuteBaby_Attack;

        IsValidCuteBaby_Density = PlayerPrefs.HasKey("CuteBaby_Density");
        CheckSaveSystemInt(IsValidCuteBaby_Density, 1, "CuteBaby_Density");



        IsValidCuteBaby_Attack = PlayerPrefs.HasKey("CuteBaby_Attack");
        CheckSaveSystemFloat(IsValidCuteBaby_Attack, 5, "CuteBaby_Attack");
    }


   


    void SavePlayerParams()
    {
        bool IsValidPlayer_Health;
        bool IsValidPlayer_CharLevel;
        bool IsValidPlayer_Flow;
        bool IsValidPlayer_IsCharAttackDamage;
        bool IsValidPlayer_IsDead;


        IsValidPlayer_Health = PlayerPrefs.HasKey("Player_Health");
        CheckSaveSystemFloat(IsValidPlayer_Health, 100, "Player_Health");

        IsValidPlayer_Flow = PlayerPrefs.HasKey("Player_Flow");
        CheckSaveSystemFloat(IsValidPlayer_Flow, 0, "Player_Flow");

        IsValidPlayer_CharLevel = PlayerPrefs.HasKey("CharLevel");
        CheckSaveSystemFloat(IsValidPlayer_CharLevel, 1, "CharLevel");

        IsValidPlayer_IsCharAttackDamage = PlayerPrefs.HasKey("CharAttackDamage");
        CheckSaveSystemFloat(IsValidPlayer_IsCharAttackDamage, 1, "CharAttackDamage");

        IsValidPlayer_IsDead = PlayerPrefs.HasKey("IsDead");
        CheckSaveSystemInt(IsValidPlayer_IsDead, 0, "IsDead");

    }

    void SaveOtherParams()
    {
        bool IsValidDifficultyLevelParam;
        bool IsValidLevelParam;
        bool IsValidPoint;

        IsValidDifficultyLevelParam = PlayerPrefs.HasKey("DifficultyLevel");
        CheckSaveSystemInt(IsValidDifficultyLevelParam,1, "DifficultyLevel");

        IsValidLevelParam = PlayerPrefs.HasKey("CurrentLevel");
        CheckSaveSystemFloat(IsValidLevelParam, 1, "CurrentLevel");

        IsValidPoint = PlayerPrefs.HasKey("Point");
        CheckSaveSystemFloat(IsValidPoint, 0, "Point");

    }

    void SaveLocationparams()
    {
        bool IsValidIsLocStart;
        bool IsValidLocX;
        bool IsValidLocY;
        bool IsValidLocZ;

        IsValidIsLocStart = PlayerPrefs.HasKey("IsLocStart");
        CheckSaveSystemFloat(IsValidIsLocStart, 1, "IsLocStart");

        IsValidLocX = PlayerPrefs.HasKey("LocX");
        CheckSaveSystemFloat(IsValidLocX, 0, "LocX");

        IsValidLocY = PlayerPrefs.HasKey("LocY");
        CheckSaveSystemFloat(IsValidLocY, 0, "LocY");

        IsValidLocZ = PlayerPrefs.HasKey("LocZ");
        CheckSaveSystemFloat(IsValidLocZ, 0, "LocZ");

    }
}
