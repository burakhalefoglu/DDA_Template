using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenManager : MonoBehaviour
{

    LoadingScreen loadingScreen;

    
    void Start()
    {
        loadingScreen = GameObject.FindGameObjectWithTag("LoadingScreen").GetComponent<LoadingScreen>();
        loadingScreen.ShowLoadingScreen();

    }

  
    void Update()
    {
        if (loadingScreen.GetFilledCount() > 0.99f)
        {
            loadingScreen.MakeZero();
        }
    }
}
