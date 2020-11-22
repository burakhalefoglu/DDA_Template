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
  
}
