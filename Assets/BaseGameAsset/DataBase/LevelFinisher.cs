using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFinisher : MonoBehaviour
{

    DataAccess dataAccess;
    GameObject FinishUI;
    GameObject player;
    Character character;
    CharLevelRaising charLevelRaising;
    GameObject FinalValue;
    GameObject GameUI;
    GameObject MobileInput;


    Text TargetDestroyedCount;
    Text FinalTimeCount;
    Text FinalScoreCount;
    Text CharLevel;
    AudioSource audioSource;



    private void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        character = player.GetComponent<Character>();

        character = player.GetComponent<Character>();
        dataAccess = this.gameObject.transform.GetChild(0).gameObject.GetComponent<DataAccess>();
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
        MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
        audioSource = GetComponent<AudioSource>();



    }
    public void GetAllDataAndFinish()
    {
       
            charLevelRaising = GetComponent<CharLevelRaising>();
            charLevelRaising.UpdateCharLevel();

            PlayerPrefs.SetInt("IsDead", 0);
            SaveUserDataForLevelfinish(player);

       
    }



    public void SaveUserDataForLevelfinish(GameObject player)
    {


        CalculatePoint();

        ShowFinishUi();

        CalculateFinisUiValue();

        AddUserData(player);

    }



    void AddUserData(GameObject other)
    {
        player = other.gameObject;

        dataAccess.verileriekle();
    }

   

    void CalculatePoint()
    {

        float point = PlayerPrefs.GetFloat("Point");
        point += character.Getpoint();
        PlayerPrefs.SetFloat("Point", point);
    }

    void ShowFinishUi()
    {
        FinishUI = GameObject.FindGameObjectWithTag("PauseMenu");
        FinishUI.transform.GetChild(0).gameObject.SetActive(true);
        FinishUI.transform.GetChild(0).GetChild(0).GetChild(3).gameObject.SetActive(true);
        GameUI.SetActive(false);
        MobileInput.SetActive(false);
        audioSource.Play();
        Time.timeScale = 0.1f;
    }

    void CalculateFinisUiValue()
    {
     //   FinalValue = GameObject.FindGameObjectWithTag("FinalValue");

        //TargetDestroyedCount = FinalValue.transform.GetChild(0).GetComponent<Text>();
        //TargetDestroyedCount.text= character.GetTotalAttack().ToString();

        //FinalTimeCount = FinalValue.transform.GetChild(1).GetComponent<Text>();
        //FinalTimeCount.text = this.gameObject.transform.GetChild(0).GetComponent<GettingDatabaseParameters>().FinishingTime().ToString();

        //FinalScoreCount = FinalValue.transform.GetChild(2).GetComponent<Text>();
        //FinalScoreCount.text = character.Getpoint().ToString();

        //CharLevel = FinalValue.transform.GetChild(3).GetComponent<Text>();
        //CharLevel.text = PlayerPrefs.GetFloat("CharLevel").ToString();


    }

   
}
