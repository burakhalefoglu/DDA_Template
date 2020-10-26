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
        SceneManager.LoadScene((int)PlayerPrefs.GetFloat("CurrentLevel"));

    }




    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LoadingSceene");



    }

    public void NextLevel()
    {
        SceneManager.LoadScene("LoadingSceene");

    }


}
