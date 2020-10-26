﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{

    [SerializeField]
    Text percentLoaded;

    [SerializeField]
    Image FilledImage;

    float loadProgress;
    AsyncOperation loadingOperation;
    public void ShowLoadingScreen()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        loadingOperation = SceneManager.LoadSceneAsync((int)PlayerPrefs.GetFloat("CurrentLevel"));


    }

    public void MakeZero()
    {
        loadProgress = 0;
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void Update()
    {
        loadProgress = loadingOperation.progress;
        Debug.Log(loadProgress);

        FilledImage.fillAmount = loadProgress;
        percentLoaded.text = Mathf.Round(loadProgress * 100) + "%";
    }

    public float GetFilledCount()
    {
        return FilledImage.fillAmount;
    }
}
