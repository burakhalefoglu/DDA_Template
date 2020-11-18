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
        SaveBloodCellParams();
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
        CheckSaveSystemFloat(IsValidVırus_Density, 5, "Vırus_Density");

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
        CheckSaveSystemFloat(IsValidGermSlime_Density, 10, "GermSlime_Density");

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
        CheckSaveSystemFloat(IsValidGermSpike_Density, 10, "GermSpike_Density");


    }

    void SaveCuteMushyParams()
    {
        bool IsValidCuteMushy_Density;

        IsValidCuteMushy_Density = PlayerPrefs.HasKey("CuteMushy_Density");
        CheckSaveSystemFloat(IsValidCuteMushy_Density, 10, "CuteMushy_Density");
    }

    void SaveCuteBacteriumParams()
    {
        bool IsValidCuteBacterium_Density;

        IsValidCuteBacterium_Density = PlayerPrefs.HasKey("CuteBacterium_Density");
        CheckSaveSystemFloat(IsValidCuteBacterium_Density, 10, "CuteBacterium_Density");
    }


    void SaveHelloKittyParams()
    {
        bool IsValidHelloKitty_Density;

        IsValidHelloKitty_Density = PlayerPrefs.HasKey("HelloKitty_Density");
        CheckSaveSystemFloat(IsValidHelloKitty_Density, 10, "HelloKitty_Density");
    }
    
    void SaveEnemyTopParams()
    {
        bool IsValidEnemyTop_Density;

        IsValidEnemyTop_Density = PlayerPrefs.HasKey("EnemyTop_Density");
        CheckSaveSystemFloat(IsValidEnemyTop_Density, 10, "EnemyTop_Density");
    }

    void SaveCuteBabyParams()
    {
        bool IsValidCuteBaby_Density;
        bool IsValidCuteBaby_Attack;

        IsValidCuteBaby_Density = PlayerPrefs.HasKey("CuteBaby_Density");
        CheckSaveSystemFloat(IsValidCuteBaby_Density, 10, "CuteBaby_Density");



        IsValidCuteBaby_Attack = PlayerPrefs.HasKey("CuteBaby_Attack");
        CheckSaveSystemFloat(IsValidCuteBaby_Attack, 5, "CuteBaby_Attack");
    }


    void SaveBloodCellParams()
    {
        bool IsValidBloodCell_Density;
        bool IsValidBloodCell_GiftBulletCount;

        IsValidBloodCell_Density = PlayerPrefs.HasKey("BloodCell_Density");
        CheckSaveSystemFloat(IsValidBloodCell_Density, 10, "BloodCell_Density");

        IsValidBloodCell_GiftBulletCount = PlayerPrefs.HasKey("GiftBulletCount");
        CheckSaveSystemFloat(IsValidBloodCell_GiftBulletCount, 10, "GiftBulletCount");

    }
    void SavePlayerParams()
    {
        bool IsValidPlayer_Health;
        bool IsValidPlayer_GermOBlasterBullet;
        bool IsValidPlayer_Healmatic500Bullet;
        bool IsValidPlayer_PillCount;
        bool IsValidPlayer_CharLevel;
        bool IsValidPlayer_Flow;
        bool IsCharAttackDamage;

        IsValidPlayer_Health = PlayerPrefs.HasKey("Player_Health");
        CheckSaveSystemFloat(IsValidPlayer_Health, 100, "Player_Health");

        IsValidPlayer_Flow = PlayerPrefs.HasKey("Player_Flow");
        CheckSaveSystemFloat(IsValidPlayer_Flow, 0, "Player_Flow");

        IsValidPlayer_GermOBlasterBullet = PlayerPrefs.HasKey("GermOBlasterBullet");
        CheckSaveSystemFloat(IsValidPlayer_GermOBlasterBullet, 100, "GermOBlasterBullet");

        IsValidPlayer_Healmatic500Bullet = PlayerPrefs.HasKey("Healmatic500Bullet");
        CheckSaveSystemFloat(IsValidPlayer_Healmatic500Bullet, 100, "Healmatic500Bullet");

        IsValidPlayer_PillCount = PlayerPrefs.HasKey("PillCount");
        CheckSaveSystemFloat(IsValidPlayer_PillCount, 100, "PillCount");

        IsValidPlayer_CharLevel = PlayerPrefs.HasKey("CharLevel");
        CheckSaveSystemFloat(IsValidPlayer_CharLevel, 1, "CharLevel");

        IsCharAttackDamage = PlayerPrefs.HasKey("CharAttackDamage");
        CheckSaveSystemFloat(IsCharAttackDamage, 1, "CharAttackDamage");
        
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
