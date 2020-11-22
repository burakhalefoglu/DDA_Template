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
    int IsDead=0;
    float EnemyTopAttackCount = 1;
    float time;
    int ClosestCheckPointIndex = 0;

    GameObject PointValueObject;
    GameObject PauseMenu;
    GameObject GameUI;
    GameObject MobileInput;
    GameObject HealthBar;
    HealthBarHandler healthBarHandler;
    Controller controller;
    Text PointValue;
    LevelFinisher levelFinisher;
    AudioSource [] audioData;
    GameObject DamageUi;
    Animator animatorController;
    bool heartAttackStart;

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

        audioData = GetComponents<AudioSource>();

        DamageUi = GameObject.FindGameObjectWithTag("DamageUi");
        animatorController = DamageUi.transform.GetChild(0).gameObject.GetComponent<Animator>();

        heartAttackStart = false;
        StartCoroutine(RotateChar());
        
    }

    private void OnTriggerEnter(Collider other)
    {
        DamageUi = GameObject.FindGameObjectWithTag("DamageUi");
        animatorController = DamageUi.transform.GetChild(0).gameObject.GetComponent<Animator>();

        if (other.gameObject.tag == "GermSlimeBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("GermSlime_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("GermSlime_Attack"));
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);
        }
        else if (other.gameObject.tag == "CuteVirusBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack"));
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (other.gameObject.tag == "BossVirusBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack")*2;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 2);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (other.gameObject.tag == "DomestosBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack") * 3;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 3);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (other.gameObject.tag == "BossFlyBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack") *4;
            CalculateHealthBar(PlayerPrefs.GetFloat("Virus_Attack") * 4);
            audioData[0].Play();
            animatorController.SetBool("GetHit",true);

        }
        else if (other.gameObject.tag == "CuteBabyBullet" && health > 0)
        {
            health -= PlayerPrefs.GetFloat("CuteBaby_Attack");
            CalculateHealthBar(PlayerPrefs.GetFloat("CuteBaby_Attack"));
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }

        else if (other.gameObject.tag == "FootMicrobeBullet" && health > 0)
        {
            health -= 20;
            CalculateHealthBar(20);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }

        else if (other.gameObject.tag == "Mushy" && health > 0)
        {
            health -= mashroomAttack;
            CalculateHealthBar(mashroomAttack);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        DamageUi = GameObject.FindGameObjectWithTag("DamageUi");
        animatorController = DamageUi.transform.GetChild(0).gameObject.GetComponent<Animator>();

        if (collision.gameObject.tag == "bacterium" && health > 0)
        {
            health -= bacteriumAttack;
            CalculateHealthBar(bacteriumAttack);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (collision.gameObject.tag == "HelloKitty" && health > 0)
        {
            health -= HelloKittyAttack;
            CalculateHealthBar(HelloKittyAttack);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (collision.gameObject.tag == "GermSpike" && health > 0)
        {
            health -= GermSpike;
            CalculateHealthBar(GermSpike);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

        }
        else if (collision.gameObject.tag == "EnemyTop" && health > 0)
        {
            health -= EnemyTopAttackCount;
            CalculateHealthBar(EnemyTopAttackCount);
            audioData[0].Play();
            animatorController.SetBool("GetHit",true);

        }
        else if (collision.gameObject.tag == "ChildSpike" && health > 0)
        {
            health -= 1;
            CalculateHealthBar(1);
            audioData[0].Play();
            animatorController.SetBool("GetHit", true);

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
    public int GetPlayerDeadInformation()
    {
        return IsDead;

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


    private void Update()
    {
        DamageUi = GameObject.FindGameObjectWithTag("DamageUi");
        animatorController = DamageUi.transform.GetChild(0).gameObject.GetComponent<Animator>();
        CalculatePlayerFlow();

        if (animatorController.GetBool("GetHit"))
        {
            time += Time.deltaTime;
            if (time > .5f)
            {
                time = 0;
                animatorController.SetBool("GetHit", false);
            }
        }

        if (health < 30 && !heartAttackStart)
        {
            heartAttackStart = true;
            audioData[2].Play();
        }

        if (health <= 0 && IsDead==0)
        {
            audioData[1].Play();
            IsDead = 1;
            PlayerPrefs.SetInt("IsDead", IsDead);
            PauseGame();
        }

    }

    public void CalculatePlayerFlow()
    {
        float RemainHealth = GetPlayerHealth();
        float flow = 100 - ((100 * RemainHealth) / firstHealth);
        PlayerPrefs.SetFloat("Player_Flow", flow);
    }



    IEnumerator RotateChar()
    {
        yield return new WaitForSeconds(.1f);
        GameObject[] Checkpoint = GameObject.FindGameObjectsWithTag("CheckPoint");
        float Dist = 0;
        float temp = 0 ;
        Quaternion LastRot;

        for(int i=0; i < Checkpoint.Length; i++)
        {
            temp = Vector3.Distance(Checkpoint[i].transform.position, transform.position);

            if (i == 0)
            {
                
                Dist = temp;
            }
            else if (temp < Dist)
            {

                Dist = temp;
                ClosestCheckPointIndex = i;

            }
            
        }

        LastRot = Quaternion.LookRotation(Checkpoint[ClosestCheckPointIndex].transform.position - transform.position);
        transform.rotation = new Quaternion(transform.rotation.x, LastRot.y + 90, transform.rotation.z, 1);
    }

}
