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

    public void StartLevel()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().enabled = false;
        StartCoroutine(DelaySceneLoad());

    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("LoadingSceeneMM");
    }
}
