    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GettingDifficultySettings : MonoBehaviour
{
    int currentlevel;
    //Siinecek...//
    GameObject DataToScreen;



    void Start()
    {
        DataToScreen = GameObject.FindGameObjectWithTag("DataToScreen");
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        DataToScreen.transform.GetChild(0).GetChild(1).GetChild(25).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("DifficultyLevel").ToString();
        DataToScreen.transform.GetChild(0).GetChild(1).GetChild(26).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CurrentLevel").ToString();

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


    // DataToScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Text>().text=

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

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteMushy_Density").ToString();

                        }
                        break;
                    case 1:
                        childcount = PlayerPrefs.GetInt("CuteBacterium_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);
                            
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(5).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteBacterium_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(6).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(7).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(9).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();

                        }
                        break;
                    case 2:
                        childcount = PlayerPrefs.GetInt("GermSpike_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(10).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteBacterium_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(11).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(12).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(14).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();


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

                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteMushy_Density").ToString();

                            }

                            break;
                        case 1:
                            childcount = PlayerPrefs.GetInt("CuteBacterium_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(5).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteBacterium_Density").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(6).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Health").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(7).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Attack").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(9).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();


                            }
                            break;

                        case 2:
                            childcount = PlayerPrefs.GetInt("GermSpike_Density");
                            for (int j = 0; j < childcount; j++)
                            {
                                this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(10).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteBacterium_Density").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(11).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Health").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(12).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBacterium_Attack").ToString();
                                DataToScreen.transform.GetChild(0).GetChild(1).GetChild(14).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();

                            }
                            break;

                       case 3:
                                childcount = PlayerPrefs.GetInt("GermSlime_Density");
                                for (int j = 0; j < childcount; j++)
                                {
                                    this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                                    DataToScreen.transform.GetChild(0).GetChild(1).GetChild(15).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("GermSlime_Density").ToString();
                                    DataToScreen.transform.GetChild(0).GetChild(1).GetChild(16).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Health").ToString();
                                    DataToScreen.transform.GetChild(0).GetChild(1).GetChild(17).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Attack").ToString();
                                    DataToScreen.transform.GetChild(0).GetChild(1).GetChild(18).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Attack_Density").ToString();
                                    DataToScreen.transform.GetChild(0).GetChild(1).GetChild(19).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();


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

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("EnemyTop_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("EnemyTop_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(2).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("EnemyTop_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(4).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();

                        }
                        break;
                    case 1:
                        childcount = PlayerPrefs.GetInt("HelloKitty_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(5).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("HelloKitty_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(6).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("HelloKitty_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(7).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("HelloKitty_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(9).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();
                        }
                        break;
                    case 2:
                        childcount = PlayerPrefs.GetInt("CuteBaby_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(10).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CuteBaby_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(11).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBaby_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(12).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("CuteBaby_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(14).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();

                                    
                        }
                        break;

                    case 3:
                        childcount = PlayerPrefs.GetInt("GermSlime_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(15).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("GermSlime_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(16).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(17).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(18).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("GermSlime_Attack_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(19).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();


                        }
                        break;
                    case 4:
                        childcount = PlayerPrefs.GetInt("Vırus_Density");
                        for (int j = 0; j < childcount; j++)
                        {
                            this.gameObject.transform.GetChild(i).GetChild(j).gameObject.SetActive(true);

                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(20).gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Vırus_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(21).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Virus_Health").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(22).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Virus_Attack").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(23).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Virus_Attack_Density").ToString();
                            DataToScreen.transform.GetChild(0).GetChild(1).GetChild(24).gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("Walk_Speed").ToString();


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
