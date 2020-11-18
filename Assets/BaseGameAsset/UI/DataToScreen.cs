using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataToScreen : MonoBehaviour
{

    [SerializeField]
    Text DifficultyLevel;
    [SerializeField]
    Text RemainingHealth;
    [SerializeField]
    Text CharLevel;
    [SerializeField]
    Text AttackSpeed;
    [SerializeField]
    Text HitRate;
    [SerializeField]
    Text FinishingTime;

    float time;

    LevelFinisher levelFinisher;
    GettingDatabaseParameters gettingDatabaseParameters;
    private void Start()
    {
        levelFinisher = this.gameObject.GetComponent<LevelFinisher>();
        gettingDatabaseParameters = this.gameObject.transform.GetChild(0).gameObject.GetComponent<GettingDatabaseParameters>();
    }



    private void Update()
    {
        time += Time.deltaTime;

        if (time > 0.5f)
        {
            time = 0;
            CalculateAllData();
            ScreenToData();
        }
       
    }


    void CalculateAllData()
    {
        levelFinisher.SetUserDatas();


    }

    void ScreenToData()
    {
        DifficultyLevel.text =PlayerPrefs.GetFloat("DifficultyLevel").ToString();
        CharLevel.text = PlayerPrefs.GetFloat("CharLevel").ToString();
        RemainingHealth.text = gettingDatabaseParameters.RemainingHealth().ToString();
        AttackSpeed.text = gettingDatabaseParameters.AttackSpeed().ToString();
        HitRate.text = gettingDatabaseParameters.HitRate().ToString();
        FinishingTime.text = gettingDatabaseParameters.FinishingTime().ToString();
    }

}
