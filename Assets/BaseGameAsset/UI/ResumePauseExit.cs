using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumePauseExit : MonoBehaviour
{
   public void ResumePause()
    {
        if (Time.timeScale == 0.001f)
        {
            this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
            Time.timeScale = 1f;
        }

        else 
        {
            this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            Time.timeScale = 0.001f;
        }

   }


    public void Exit()
    {
        Application.Quit();
    }

}
