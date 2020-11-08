using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

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
            Debug.Log("Error");
            action(false);
        }
        else
        {
            Debug.Log("Success");
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
        Debug.Log(difficulty);
        if (difficulty == 0)
        {
            SetManualDDA();
        }
        else
        {
            difficultyManager = GetComponent<DifficultyManager>();
            difficultyManager.CalculateDifficultyLevel(difficulty);
        }
    }

    void SetManualDDA()
    {
        float DifficultyLevel;
        if (PlayerPrefs.GetFloat("CurrentLevel") == 1)
        {
            difficultyManager = GetComponent<DifficultyManager>();
            difficultyManager.CalculateDifficultyLevel(5);


        }
        else
        {
            if (PlayerPrefs.GetFloat("Player_Flow") < 80)
            {
                DifficultyLevel = PlayerPrefs.GetFloat("CurrentLevel") + 1;
                difficultyManager.CalculateDifficultyLevel((int)DifficultyLevel);
                return;
            }
            else if (PlayerPrefs.GetFloat("Player_Flow") > 95)
            {
                DifficultyLevel = PlayerPrefs.GetFloat("CurrentLevel") - 1;
                difficultyManager.CalculateDifficultyLevel((int)DifficultyLevel);
                return;
            }
            
            DifficultyLevel = PlayerPrefs.GetFloat("CurrentLevel");
            DifficultyLevel= UnityEngine.Random.Range(DifficultyLevel - 1, DifficultyLevel + 1);
            difficultyManager.CalculateDifficultyLevel((int)DifficultyLevel);

        }
    }
}
