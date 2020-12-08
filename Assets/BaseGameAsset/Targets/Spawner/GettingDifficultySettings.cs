﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GettingDifficultySettings : MonoBehaviour
{
    int currentlevel;




    void Start()
    {
        currentlevel = SceneManager.GetActiveScene().buildIndex;
    }


    void setVisibility(int currentlevel)
    {
        if (currentlevel > 0 && currentlevel <= 3)
        {
            for (int i = 0; i < 3; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
        else if (currentlevel > 3 && currentlevel <= 6)
        {
            for (int i = 0; i < 4; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
        else if(currentlevel>6)
        {
            for (int i = 0; i < 5; i++)
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);

        }
    }



    void CalculateDesisity(int currentlevel)
    {
        if (currentlevel > 0 && currentlevel <= 5)
        {
            for (int i = 0; i < 3; i++)
            {
                float childcount=this.gameObject.transform.GetChild(i).childCount;
                switch (i)
                {
                    case 0:
                        childcount= PlayerPrefs.GetInt("CuteMushy_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);


                        }
                        break;
                    case 1:
                        childcount = PlayerPrefs.GetInt("CuteBacterium_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);
                            
                     

                        }
                        break;
                    case 2:
                        childcount = PlayerPrefs.GetInt("GermSpike_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                        }
                        break;
                }
            }

        }


        else if (currentlevel > 5 && currentlevel <= 8)
        {
            for (int i = 0; i < 4; i++)
            {
                    float childcount = this.gameObject.transform.GetChild(i).childCount;
                    switch (i)
                    {
                        case 0:
                            childcount = PlayerPrefs.GetInt("CuteMushy_Density");

                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);


                            }

                            break;
                        case 1:
                            childcount = PlayerPrefs.GetInt("CuteBacterium_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            }
                            break;

                        case 2:
                            childcount = PlayerPrefs.GetInt("GermSpike_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            }
                            break;

                       case 3:
                                childcount = PlayerPrefs.GetInt("GermSlime_Density");
                                for (int j = 0; j < childcount; j++)
                                {
                                    this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);


                                }
                                break;
                    }
                
            }



        }

        else if (currentlevel > 8)
        {
            for (int i = 0; i < 5; i++)
            {
                float childcount = this.gameObject.transform.GetChild(i).childCount;

                switch (i)
                {
                    case 0:
                        childcount = PlayerPrefs.GetInt("EnemyTop_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);


                        }
                        break;
                    case 1:
                        childcount = PlayerPrefs.GetInt("HelloKitty_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                        }
                        break;
                    case 2:
                        childcount = PlayerPrefs.GetInt("CuteBaby_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                                    
                        }
                        break;

                    case 3:
                        childcount = PlayerPrefs.GetInt("GermSlime_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);



                        }
                        break;
                    case 4:
                        childcount = PlayerPrefs.GetInt("Vırus_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

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
            PlayerPrefs.SetFloat("IsLocStart", 0);
            Vector3 location = new Vector3();
            location = this.gameObject.transform.GetChild(5).transform.position;
            PlayerPrefs.SetFloat("LocX", location.x);
            PlayerPrefs.SetFloat("LocY", location.y);
            PlayerPrefs.SetFloat("LocZ", location.z);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }



}
