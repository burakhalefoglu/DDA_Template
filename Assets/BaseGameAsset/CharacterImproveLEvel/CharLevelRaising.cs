﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharLevelRaising : MonoBehaviour
{
   
    public void UpdateCharLevel()
    {
        if ((SceneManager.GetActiveScene().name) == "4")
        {
            UpdateWork(125, 1.25f);
            PlayerPrefs.SetFloat("CharLevel", 2);
        }
        else if ((SceneManager.GetActiveScene().name) == "8")
        {
            UpdateWork(150, 1.50f);
            PlayerPrefs.SetFloat("CharLevel", 3);

        }
        else if ((SceneManager.GetActiveScene().name) == "10")
        {
            UpdateWork(200, 2f);
            PlayerPrefs.SetFloat("CharLevel", 4);
            ShowSurvey();
        }
        else if ((SceneManager.GetActiveScene().name) == "12")
        {
            UpdateWork(250, 2.5f);
            PlayerPrefs.SetFloat("CharLevel", 5);

        }
    }

    void UpdateWork(float Player_Health, float CharAttackDamage)
    {
        PlayerPrefs.SetFloat("Player_Health", Player_Health);
        PlayerPrefs.SetFloat("CharAttackDamage", CharAttackDamage);
    }



    void ShowSurvey()
    {



    }
}
