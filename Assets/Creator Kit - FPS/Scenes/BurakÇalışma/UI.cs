﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    

   public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);


    }
}
