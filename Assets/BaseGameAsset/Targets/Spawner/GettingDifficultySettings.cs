using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GettingDifficultySettings : MonoBehaviour
{
    int currentlevel;
    // Start is called before the first frame update
    void Start()
    {
      
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        
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



    void CalculateDesisity(int currentlevel)
    {
        if (currentlevel > 0 && currentlevel < 5)
        {
            for (int i = 0; i < 3; i++)
            {
                float childcount=this.gameObject.transform.GetChild(i).childCount;
                switch (i)
                {
                    case 0:
                        childcount= childcount - PlayerPrefs.GetFloat("CuteMushy_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                            break;
                    case 1:
                        childcount = childcount - PlayerPrefs.GetFloat("CuteBacterium_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                    case 2:
                        childcount = childcount - PlayerPrefs.GetFloat("GermSpike_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                }
            }
                
        }
        else if (currentlevel > 4 && currentlevel < 9)
        {
            for (int i = 0; i < 4; i++)
            {
                    float childcount = this.gameObject.transform.GetChild(i).childCount;
                    switch (i)
                    {
                        case 0:
                            childcount = childcount - PlayerPrefs.GetFloat("CuteMushy_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                            }
                            break;
                        case 1:
                            childcount = childcount - PlayerPrefs.GetFloat("CuteBacterium_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                            }
                            break;
                        case 2:
                            childcount = childcount - PlayerPrefs.GetFloat("GermSpike_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                            }
                            break;

                       case 3:
                                childcount = childcount - PlayerPrefs.GetFloat("GermSlime_Density");
                                for (int j = 0; j < childcount; j++)
                                {
                                    this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                                }
                                break;
                    }
                
            }
                
        }

        else
        {
            for (int i = 0; i < 5; i++)
            {
                float childcount = this.gameObject.transform.GetChild(i).childCount;
                switch (i)
                {
                    case 0:
                        childcount = childcount - PlayerPrefs.GetFloat("CuteMushy_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                    case 1:
                        childcount = childcount - PlayerPrefs.GetFloat("CuteBacterium_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                    case 2:
                        childcount = childcount - PlayerPrefs.GetFloat("GermSpike_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;

                    case 3:
                        childcount = childcount - PlayerPrefs.GetFloat("GermSlime_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                    case 4:
                        childcount = childcount - PlayerPrefs.GetFloat("Vırus_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
                        }
                        break;
                }


            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            setVisibility(currentlevel);
            CalculateDesisity(currentlevel);
        }
    }
}
