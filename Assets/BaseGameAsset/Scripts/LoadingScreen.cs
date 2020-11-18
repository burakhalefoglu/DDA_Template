using System.Collections;
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

        if (SceneManager.GetActiveScene().name == "LoadingSceene")
        {
            float Currentlevel = PlayerPrefs.GetFloat("CurrentLevel") + 1;
            PlayerPrefs.SetFloat("CurrentLevel", Currentlevel);
        }

        PlayerPrefs.SetFloat("IsLocStart", 1);
        loadingOperation = SceneManager.LoadSceneAsync((int)PlayerPrefs.GetFloat("CurrentLevel"));



    }

    public void MakeZero()
    {
        loadProgress = 0;
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Time.frameCount % 3 == 0)
        {

            loadProgress = loadingOperation.progress;

            FilledImage.fillAmount = loadProgress;
            percentLoaded.text = Mathf.Round(loadProgress * 100) + "%";
        }

    }
    public float GetFilledCount()
    {
        return FilledImage.fillAmount;
    }
}
