using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumePauseExit : MonoBehaviour
{
   public void ResumePause()
    {
        if (Time.timeScale == 0.1f)
        {
            Time.timeScale = 1f;
        }

        else if (Time.timeScale == 1f)
        {
            Time.timeScale = 0.1f;
        }

   }


    public void Exit()
    {
        Application.Quit();
    }

}
