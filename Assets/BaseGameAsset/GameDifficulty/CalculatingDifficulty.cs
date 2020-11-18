using Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatingDifficulty : MonoBehaviour, ICalculate
{
    public int CalculateEnemyCount(int DifficultyLevel, int IncreaseAmount, int DifficultyOneParameter)
    {

       int RanomizationCount = RandomizationCount(DifficultyLevel);
       float FloatDifficultyParamMedyan = DifficultyOneParameter + (IncreaseAmount * (DifficultyLevel - 1));
       int DifficultyParamMedyan=(int)Math.Round(FloatDifficultyParamMedyan, MidpointRounding.AwayFromZero);

        return UnityEngine.Random.Range((int)(DifficultyParamMedyan - RanomizationCount), (int)(DifficultyParamMedyan + RanomizationCount));

    }

    public int CalculateEnemysIncreaseAmount(int DifficultyOneCount, int DifficultyTenCount)
    {
        int IncreaseAmount =(int)(DifficultyTenCount - DifficultyOneCount) / 9;

        return IncreaseAmount;
    }

    public int RandomizationCount(float CurrentLevel)
    {
        if (CurrentLevel > 0 && CurrentLevel < 5)
        {
            return  1;
        }
        else if (CurrentLevel > 4 && CurrentLevel < 8)
        {
            return 3;
        }
        else
        {
            return 5;
        }
    }
  
}
