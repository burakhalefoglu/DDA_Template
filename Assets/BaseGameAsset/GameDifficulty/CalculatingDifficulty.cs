using Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatingDifficulty : MonoBehaviour, ICalculate
{
    public int CalculateEnemyCount(int DifficultyLevel, float IncreaseAmount, int DifficultyOneParameter)
    {
        Debug.Log(IncreaseAmount);

       float DifficultyParamMedyan = DifficultyOneParameter + (IncreaseAmount * (DifficultyLevel - 1));

        return (int)DifficultyParamMedyan;

    }

    public float CalculateEnemysIncreaseAmount(int DifficultyOneCount, int DifficultyTenCount)
    {
        float IncreaseAmount = (DifficultyTenCount - DifficultyOneCount) / 9;

        return IncreaseAmount;
    }
  
    public float CalculateAttackDensity(float diffiultyLevel)
    {
        return (UnityEngine.Random.Range(3.5f, 4.5f)) - (0.2f * diffiultyLevel);
    }

    public float CalculateAttackcount(float diffiultyLevel,int enemyMinAttack, int enemyMaxAttack, int IncreaseAmount)
    {
        return (UnityEngine.Random.Range(enemyMinAttack, enemyMaxAttack)) + (IncreaseAmount * diffiultyLevel);
    }
    

    public float CalculateWalkSpeed(float diffiultyLevel)
    {
        if (diffiultyLevel > 4)
        {
            return 0.20f;
        }
        else if (diffiultyLevel > 8)
        {
            return 0.30f;
        }
        else
        {
            return 0.40f;

        }
    }
}
