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
            difficultyManager.CalculateDifficultyLevel(difficulty);
        }
    }

    void SetManualDDA()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            return;
        }

        int DifficultyLevel;
        if (PlayerPrefs.GetFloat("CurrentLevel") == 1)
        {
            difficultyManager = GetComponent<DifficultyManager>();
            PlayerPrefs.SetInt("DifficultyLevel", 1);
            difficultyManager.CalculateDifficultyLevel(1);


        }

        else
        {
            if (PlayerPrefs.GetFloat("Player_Flow") > 90)
            {
                DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel") - 1;
                difficultyManager = GetComponent<DifficultyManager>();
                PlayerPrefs.SetInt("DifficultyLevel", DifficultyLevel);
                difficultyManager.CalculateDifficultyLevel(DifficultyLevel);
                return;
            }
            else if (PlayerPrefs.GetFloat("Player_Flow") < 65)
            {
                DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel") + 1;
                difficultyManager = GetComponent<DifficultyManager>();
                PlayerPrefs.SetInt("DifficultyLevel", DifficultyLevel);
                difficultyManager.CalculateDifficultyLevel(DifficultyLevel);
                return;
            }
            
            DifficultyLevel = PlayerPrefs.GetInt("DifficultyLevel");
            DifficultyLevel= UnityEngine.Random.Range(DifficultyLevel - 1, DifficultyLevel + 1);
            difficultyManager = GetComponent<DifficultyManager>();
            difficultyManager.CalculateDifficultyLevel(DifficultyLevel);

        }
    }
}
