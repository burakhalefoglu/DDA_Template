using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{


    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }


    public void StartLevel()
    {
        SceneManager.LoadScene("LoadingSceeneMM");

    }




    public void RestartLevel()
    {
        SceneManager.LoadScene("LoadingSceene");
        PlayerPrefs.SetFloat("IsRestart", 1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("LoadingSceene");
        PlayerPrefs.SetFloat("IsRestart", 0);

    }


}
