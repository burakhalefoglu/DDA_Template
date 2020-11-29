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
        SaveEnemyTopParams();
        SaveCuteBabyParams();

        SavePlayerParams();

        SaveOtherParams();
        SaveLocationparams();
        KeyGenerator();

        PlayerPrefs.Save();
       

    }

    void KeyGenerator()
    {
        bool IsDevideId;
        int DevideId = Random.Range(111111111, 999999999);
        IsDevideId = PlayerPrefs.HasKey("DevideId");
        CheckSaveSystemInt(IsDevideId, DevideId, "DevideId");
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
        bool IsValidVirus_Attack_Density;

        IsValidVirus_Health = PlayerPrefs.HasKey("Virus_Health");
        CheckSaveSystemFloat(IsValidVirus_Health, 10, "Virus_Health");

        IsValidVirus_Attack = PlayerPrefs.HasKey("Virus_Attack");
        CheckSaveSystemFloat(IsValidVirus_Attack, 4, "Virus_Attack");

        IsValidVırus_Density = PlayerPrefs.HasKey("Vırus_Density");
        CheckSaveSystemInt(IsValidVırus_Density, 1, "Vırus_Density");

        IsValidVirus_Attack_Density = PlayerPrefs.HasKey("Virus_Attack_Density");
        CheckSaveSystemFloat(IsValidVirus_Attack_Density, 2, "Virus_Attack_Density");


    }

    void SaveGermSlimParams()
    {
        bool IsValidGermSlime_Health;
        bool IsValidGermSlime_Attack;
        bool IsValidGermSlime_Density;
        bool IsValidGermSlime_Attack_Density;



        IsValidGermSlime_Health = PlayerPrefs.HasKey("GermSlime_Health");
        CheckSaveSystemFloat(IsValidGermSlime_Health, 10, "GermSlime_Health");

        IsValidGermSlime_Attack = PlayerPrefs.HasKey("GermSlime_Attack");
        CheckSaveSystemFloat(IsValidGermSlime_Attack, 5, "GermSlime_Attack");

        IsValidGermSlime_Density = PlayerPrefs.HasKey("GermSlime_Density");
        CheckSaveSystemInt(IsValidGermSlime_Density, 1, "GermSlime_Density");

        IsValidGermSlime_Attack_Density = PlayerPrefs.HasKey("GermSlime_Attack_Density");
        CheckSaveSystemFloat(IsValidGermSlime_Attack_Density, 2, "GermSlime_Attack_Density");




    }

    void SaveGermSpikeParams()
    {
        bool IsValidGermSpike_Health;
        bool IsValidGermSpike_Density;
        bool IsValidGermSpike_Attack;

        IsValidGermSpike_Health = PlayerPrefs.HasKey("GermSpike_Health");
        CheckSaveSystemFloat(IsValidGermSpike_Health, 10, "GermSpike_Health");

        IsValidGermSpike_Density = PlayerPrefs.HasKey("GermSpike_Density");
        CheckSaveSystemInt(IsValidGermSpike_Density, 1, "GermSpike_Density");

        IsValidGermSpike_Attack = PlayerPrefs.HasKey("GermSpike_Attack");
        CheckSaveSystemFloat(IsValidGermSpike_Attack, 1, "GermSpike_Attack");



    }

    void SaveCuteMushyParams()
    {
        bool IsValidCuteMushy_Density;

        IsValidCuteMushy_Density = PlayerPrefs.HasKey("CuteMushy_Density");
        CheckSaveSystemInt(IsValidCuteMushy_Density, 1, "CuteMushy_Density");
    }

    void SaveCuteBacteriumParams()
    {
        bool IsValidCuteBacterium_Health;
        bool IsValidCuteBacterium_Density;
        bool IsValidCuteBacterium_Attack;

        IsValidCuteBacterium_Health = PlayerPrefs.HasKey("CuteBacterium_Health");
        CheckSaveSystemFloat(IsValidCuteBacterium_Health, 10, "CuteBacterium_Health");

        IsValidCuteBacterium_Density = PlayerPrefs.HasKey("CuteBacterium_Density");
        CheckSaveSystemInt(IsValidCuteBacterium_Density, 1, "CuteBacterium_Density");

        IsValidCuteBacterium_Attack = PlayerPrefs.HasKey("CuteBacterium_Attack");
        CheckSaveSystemFloat(IsValidCuteBacterium_Attack, 1, "CuteBacterium_Attack");



    }


    void SaveHelloKittyParams()
    {
        bool IsValidHelloKitty_Health;
        bool IsValidHelloKitty_Density;
        bool IsValidHelloKitty_Attack;


        IsValidHelloKitty_Health = PlayerPrefs.HasKey("HelloKitty_Health");
        CheckSaveSystemFloat(IsValidHelloKitty_Health, 10, "HelloKitty_Health");

        IsValidHelloKitty_Density = PlayerPrefs.HasKey("HelloKitty_Density");
        CheckSaveSystemInt(IsValidHelloKitty_Density, 1, "HelloKitty_Density");

        IsValidHelloKitty_Attack = PlayerPrefs.HasKey("HelloKitty_Attack");
        CheckSaveSystemFloat(IsValidHelloKitty_Attack, 1, "HelloKitty_Attack");

    }
    
    void SaveEnemyTopParams()
    {
        bool IsValidEnemyTop_Health;
        bool IsValidEnemyTop_Density;
        bool IsValidEnemyTop_Attack;

        IsValidEnemyTop_Health = PlayerPrefs.HasKey("EnemyTop_Health");
        CheckSaveSystemFloat(IsValidEnemyTop_Health, 10, "EnemyTop_Health");

        IsValidEnemyTop_Density = PlayerPrefs.HasKey("EnemyTop_Density");
        CheckSaveSystemInt(IsValidEnemyTop_Density, 1, "EnemyTop_Density");

        IsValidEnemyTop_Attack = PlayerPrefs.HasKey("EnemyTop_Attack");
        CheckSaveSystemFloat(IsValidEnemyTop_Attack, 1, "EnemyTop_Attack");

    }

    void SaveCuteBabyParams()
    {

        bool IsValidCuteBaby_Health;
        bool IsValidCuteBaby_Density;
        bool IsValidCuteBaby_Attack;

        IsValidCuteBaby_Health = PlayerPrefs.HasKey("CuteBaby_Health");
        CheckSaveSystemFloat(IsValidCuteBaby_Health, 10, "CuteBaby_Health");

        IsValidCuteBaby_Density = PlayerPrefs.HasKey("CuteBaby_Density");
        CheckSaveSystemInt(IsValidCuteBaby_Density, 1, "CuteBaby_Density");

        IsValidCuteBaby_Attack = PlayerPrefs.HasKey("CuteBaby_Attack");
        CheckSaveSystemFloat(IsValidCuteBaby_Attack, 1, "CuteBaby_Attack");

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
        bool IsValidVirus_Walk_Speed;


        IsValidDifficultyLevelParam = PlayerPrefs.HasKey("DifficultyLevel");
        CheckSaveSystemInt(IsValidDifficultyLevelParam,1, "DifficultyLevel");

        IsValidLevelParam = PlayerPrefs.HasKey("CurrentLevel");
        CheckSaveSystemFloat(IsValidLevelParam, 1, "CurrentLevel");

        IsValidPoint = PlayerPrefs.HasKey("Point");
        CheckSaveSystemFloat(IsValidPoint, 0, "Point");

        IsValidVirus_Walk_Speed = PlayerPrefs.HasKey("Walk_Speed");
        CheckSaveSystemFloat(IsValidVirus_Walk_Speed, 0.2f, "Walk_Speed");
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
