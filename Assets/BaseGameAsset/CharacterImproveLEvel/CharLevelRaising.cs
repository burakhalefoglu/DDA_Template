using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharLevelRaising : MonoBehaviour
{
   
    public void UpdateCharLevel()
    {
        if ((SceneManager.GetActiveScene().name) == "5")
        {
            UpdateWork(125, 1.25f);
            PlayerPrefs.SetFloat("CharLevel", 2);
        }
        else if ((SceneManager.GetActiveScene().name) == "9")
        {
            UpdateWork(150, 1.50f);
            PlayerPrefs.SetFloat("CharLevel", 3);

        }
        else if ((SceneManager.GetActiveScene().name) == "11")
        {
            UpdateWork(200, 2f);
            PlayerPrefs.SetFloat("CharLevel", 4);

        }
        else if ((SceneManager.GetActiveScene().name) == "13")
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

}
