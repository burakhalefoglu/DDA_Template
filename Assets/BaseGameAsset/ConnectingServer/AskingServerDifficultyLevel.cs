using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class AskingServerDifficultyLevel: MonoBehaviour
{


    DifficultyManager difficultyManager;

    bool InternetIsValid = false;
    IEnumerator CheckInternetConnection(Action<bool> action)
    {
        UnityWebRequest request = new UnityWebRequest("http://google.com");
        yield return request.SendWebRequest();
        if (request.error != null)
        {
            action(false);
        }
        else
        {
            action(true);
        }
    }

    private void Awake()
    {
        CheckInternetConnection();

    }

    void CheckInternetConnection()
    {
       
        StartCoroutine(CheckInternetConnection(isConnected =>
        {

            if (isConnected)
            {
                return;
            }
            else
            {
                SetManualDDA();
            }
        }));
    
    }

    public void ConnectServer(int difficulty)
    {
        if (difficulty == 0)
        {
            SetManualDDA();

        }
        else
        {
            difficultyManager = GetComponent<DifficultyManager>();
            PlayerPrefs.SetInt("DifficultyLevel", difficulty);
            difficultyManager.CalculateDifficultyLevel();
        }
    }




    public  void SetManualDDA()
    {

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            return;
        }

        int DifficultyLevel;
        if (PlayerPrefs.GetFloat("CurrentLevel") == 1f)
        {
            difficultyManager = GetComponent<DifficultyManager>();
            PlayerPrefs.SetInt("DifficultyLevel", 1);
            difficultyManager.CalculateDifficultyLevel();

        }
        else
        {
            if (PlayerPrefs.GetFloat("Player_Flow") > 95)
            {
                if (PlayerPrefs.GetInt("DifficultyLevel") <= 1)
                {
                    return;
                }

                DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel") - 1;
                difficultyManager = GetComponent<DifficultyManager>();
                PlayerPrefs.SetInt("DifficultyLevel", DifficultyLevel);
                difficultyManager.CalculateDifficultyLevel();
                return;
            }

            else if (PlayerPrefs.GetFloat("Player_Flow") < 75 && PlayerPrefs.GetFloat("Player_Flow") > 50)
            {
                if (PlayerPrefs.GetInt("DifficultyLevel") >=10)
                {

                    return;
                }

                DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel") + 1;
                difficultyManager = GetComponent<DifficultyManager>();
                PlayerPrefs.SetInt("DifficultyLevel", DifficultyLevel);
                difficultyManager.CalculateDifficultyLevel();
                return;

            }
            else if (PlayerPrefs.GetFloat("Player_Flow") <= 50)
            {
                if (PlayerPrefs.GetInt("DifficultyLevel") >= 10)
                {
                    return;
                }

                DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel") + 2;
                difficultyManager = GetComponent<DifficultyManager>();
                PlayerPrefs.SetInt("DifficultyLevel", DifficultyLevel);
                difficultyManager.CalculateDifficultyLevel();
                return;
            }

            if (PlayerPrefs.GetInt("DifficultyLevel") <= 1 || PlayerPrefs.GetInt("DifficultyLevel") >= 10)
            {
                return;
            }

            DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel");
            DifficultyLevel= UnityEngine.Random.Range(DifficultyLevel - 1, DifficultyLevel + 1);
            difficultyManager = GetComponent<DifficultyManager>();
            difficultyManager.CalculateDifficultyLevel();


        }

    }



   //public void tempDebugScreen()
   // {
   //     Debug.Log("DifficultyLevel" + ":  " + PlayerPrefs.GetInt("DifficultyLevel"));
   //     Debug.Log("CurrentLevel" + ":  " + PlayerPrefs.GetFloat("CurrentLevel"));


   //     Debug.Log("EnemyTop" + ":  " + PlayerPrefs.GetInt("EnemyTop_Density"));
   //     Debug.Log("HelloKitty_Density" + ":  " + PlayerPrefs.GetInt("HelloKitty_Density"));
   //     Debug.Log("CuteBaby_Density" + ":  " + PlayerPrefs.GetInt("CuteBaby_Density"));
   //     Debug.Log("GermSlime_Density" + ":  " + PlayerPrefs.GetInt("GermSlime_Density"));
   //     Debug.Log("Vırus_Density" + ":  " + PlayerPrefs.GetInt("Vırus_Density"));


   //     Debug.Log("CuteMushy_Density" + ":  " + PlayerPrefs.GetInt("CuteMushy_Density"));
   //     Debug.Log("CuteBacterium_Density" + ":  " + PlayerPrefs.GetInt("CuteBacterium_Density"));
   //     Debug.Log("GermSpike_Density" + ":  " + PlayerPrefs.GetInt("GermSpike_Density"));

   // }

}
