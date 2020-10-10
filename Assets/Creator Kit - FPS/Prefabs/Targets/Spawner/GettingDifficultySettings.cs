using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GettingDifficultySettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currentlevel;
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        setVisibility(currentlevel);

        

    }

    
    void setVisibility(int currentlevel)
    {
        if (currentlevel > 0 && currentlevel < 5)
        {
            for (int i = 0; i < 3; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
        else if (currentlevel > 4 && currentlevel < 9)
        {
            for (int i = 0; i < 4; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < 5; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

}
