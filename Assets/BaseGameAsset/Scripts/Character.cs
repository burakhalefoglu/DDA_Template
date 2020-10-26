using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    float firstHealth;
    float health;
    float mashroomAttack = 1;
    float bacteriumAttack = 1;
    float HelloKittyAttack = 1;
    float GermSpike = 5;
    float NewHealthRate = 1;
    float Point;
    float IsDead=0;
    float EnemyTopAttackCount = 1;

    GameObject PointValueObject;
    GameObject PauseMenu;
    GameObject GameUI;
    GameObject MobileInput;
    GameObject HealthBar;
    HealthBarHandler healthBarHandler;
    Controller controller;
    Text PointValue;
    LevelFinisher levelFinisher;


    private void Start()
    {
        PointValueObject = GameObject.FindGameObjectWithTag("PointValue");
        PointValue = PointValueObject.GetComponent<Text>();
        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
        MobileInput = GameObject.FindGameObjectWithTag("MobileInput");
        HealthBar = GameObject.FindGameObjectWithTag("HealthBar");
        healthBarHandler = HealthBar.GetComponent<HealthBarHandler>();

        controller = GetComponent<Controller>();
        firstHealth = PlayerPrefs.GetFloat("Player_Health");
        health = PlayerPrefs.GetFloat("Player_Health");


        levelFinisher = GameObject.FindGameObjectWithTag("LevelFinisher").GetComponent<LevelFinisher>();
        PointValue.text = Point.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "GermSlimeBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("GermSlime_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("GermSlime_Attack"));
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "CuteVirusBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack"));
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "BossVirusBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack")*2;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 2);
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "DomestosBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack") * 3;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 3);
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "BossFlyBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack") *4;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 4);
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "CuteBabyBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("CuteBaby_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("CuteBaby_Attack"));
            Debug.Log(health);

        }

        else if (other.gameObject.tag == "Mushy" && health > 0)
        {
            health -= mashroomAttack;
            CalculateHealthBar(mashroomAttack);
            Debug.Log(health);
        }

        if (health <= 0)
        {
            IsDead = 1;
            Debug.Log(health);
            PauseGame();
        }
       

    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "bacterium" && health > 0)
        {
            health -= bacteriumAttack;
            CalculateHealthBar(bacteriumAttack);
            Debug.Log(health);
        }
        else if (collision.gameObject.tag == "HelloKitty" && health > 0)
        {
            health -= HelloKittyAttack;
            CalculateHealthBar(HelloKittyAttack);
            Debug.Log(health);
        }
        else if (collision.gameObject.tag == "GermSpike" && health > 0)
        {
            health -= GermSpike;
            CalculateHealthBar(GermSpike);
            Debug.Log(health);
        }
        else if (collision.gameObject.tag == "EnemyTop" && health > 0)
        {
            health -= EnemyTopAttackCount;
            CalculateHealthBar(EnemyTopAttackCount);
            Debug.Log(health);
        }





    }




    private void PauseGame()
    {
        PauseMenu.transform.GetChild(0).gameObject.SetActive(true);
        PauseMenu.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);


        GameUI.SetActive(false);
        MobileInput.SetActive(false);
        Time.timeScale = 0;

    }
    public float GetPlayerHealth()
    {
        return health;
    }
    public float GetTotalAttack()
    {
        return controller.GetTotalAttack();
    }
    public float GetTotalHit()
    {
        return controller.GetTotalHit();

    }
    public float GetPlayerDeadInformation()
    {
        return IsDead;

    }

    void IsKilled()
    {
        if (health > 0)
        {
            return;
        }
        IsDead = 0;
        levelFinisher.SaveUserDataForLevelfinish(this.gameObject);
        Debug.Log(health);
        PauseGame();
    }



     void CalculateHealthBar(float DecraseHealth)
     {
         NewHealthRate -= (DecraseHealth / firstHealth);
        healthBarHandler.SetHealthBarValue(NewHealthRate);
     }

    public void SetPoint(float point)
    {
        this.Point += point;
        PointValue.text = Point.ToString();
    }

    public float Getpoint()
    {
        return this.Point;
    }

   
}
