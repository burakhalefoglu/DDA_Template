using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFinisher : MonoBehaviour
{

    ListeninCharBehavior listeninCharBehavior;
    DataAccess dataAccess;
    BoxCollider boxCollider;
    GameObject FinishUI;
    GameObject player;
    Character character;
    CharLevelRaising charLevelRaising;
    GameObject FinalValue;
    GameObject PauseMenu;
    GameObject GameUI;
    GameObject MobileInput;


    Text TargetDestroyedCount;
    Text FinalTimeCount;
    Text FinalScoreCount;
    Text CharLevel;
    AudioSource audioSource;


    private void Awake()
    {
        charLevelRaising.UpdateCharLevel();
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        character = player.GetComponent<Character>();
        boxCollider = this.gameObject.GetComponent<BoxCollider>();
        boxCollider.enabled = false;

        charLevelRaising = GetComponent<CharLevelRaising>();
        listeninCharBehavior = this.gameObject.transform.GetChild(0).gameObject.GetComponent<ListeninCharBehavior>();
        character = player.GetComponent<Character>();
        dataAccess = this.gameObject.transform.GetChild(0).gameObject.GetComponent<DataAccess>();
        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
        MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
        audioSource = GetComponent<AudioSource>();



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("IsDead", 0);
            SaveUserDataForLevelfinish(other.gameObject);
            PauseGame();

        }
    }
    private void PauseGame()
    {
        PauseMenu.transform.GetChild(0).gameObject.SetActive(true);
        PauseMenu.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);

        GameUI.SetActive(false);
        MobileInput.SetActive(false);
        audioSource.Play();
        Time.timeScale = 0;
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

        SetUserDatas();
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
        FinishUI = GameObject.FindGameObjectWithTag("SucceesLevel");
        FinishUI.transform.GetChild(0).gameObject.SetActive(true);
    }

    void CalculateFinisUiValue()
    {
        FinalValue = GameObject.FindGameObjectWithTag("FinalValue");

        TargetDestroyedCount = FinalValue.transform.GetChild(0).GetComponent<Text>();
        TargetDestroyedCount.text= listeninCharBehavior.GetPlayerTotalAttackCount().ToString();

        FinalTimeCount = FinalValue.transform.GetChild(1).GetComponent<Text>();
        FinalTimeCount.text = this.gameObject.transform.GetChild(0).GetComponent<GettingDatabaseParameters>().FinishingTime().ToString();

        FinalScoreCount = FinalValue.transform.GetChild(2).GetComponent<Text>();
        FinalScoreCount.text = character.Getpoint().ToString();

        CharLevel = FinalValue.transform.GetChild(3).GetComponent<Text>();
        CharLevel.text = PlayerPrefs.GetFloat("CharLevel").ToString();


    }

    public void SetUserDatas()
    {
        listeninCharBehavior.SetPlayerFinishHealth((int)character.GetPlayerHealth());
        listeninCharBehavior.SetPlayerTotalAttackCount((int)character.GetTotalAttack());
        listeninCharBehavior.SetPlayerTotalOnHit((int)character.GetTotalHit());
        listeninCharBehavior.SetPlayerDeadInformation((int)character.GetPlayerDeadInformation());
    }
}
