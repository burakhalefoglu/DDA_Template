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

    Text TargetDestroyedCount;
    Text FinalTimeCount;
    Text FinalScoreCount;
    Text CharLevel;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        character = player.GetComponent<Character>();
        boxCollider = this.gameObject.GetComponent<BoxCollider>();
        boxCollider.enabled = false;
    }
    private void Start()
    {
        charLevelRaising = GetComponent<CharLevelRaising>();
        listeninCharBehavior = this.gameObject.transform.GetChild(0).gameObject.GetComponent<ListeninCharBehavior>();
        character = player.GetComponent<Character>();
        dataAccess = this.gameObject.transform.GetChild(0).gameObject.GetComponent<DataAccess>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SaveUserDataForLevelfinish(other.gameObject);
            PlayerPrefs.SetFloat("CurrentLevel", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetFloat("IsLocStart", 1);
        }
    }


    public void SaveUserDataForLevelfinish(GameObject player)
    {

        CalculatePlayerFlow();

        CalculatePoint();

        ShowFinishUi();

        charLevelRaising.UpdateCharLevel();

        CalculateFinisUiValue();

        AddUserData(player);

    }



    void AddUserData(GameObject other)
    {
        player = other.gameObject;

        SetUserDatas();
        dataAccess.verileriekle();
    }

    public void CalculatePlayerFlow()
    {
        float RemainHealth = character.GetPlayerHealth();
        float PlayerHealth = PlayerPrefs.GetFloat("Player_Health");
        float flow = 100 - ((100 * RemainHealth) / PlayerPrefs.GetFloat("Player_Health"));
        PlayerPrefs.SetFloat("Player_Flow", flow);
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
