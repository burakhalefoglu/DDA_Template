using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    float health;
    float mashroomAttack = 1;
    float bacteriumAttack = 1;
    float GermSpike = 5;
    Controller controller;
    float IsDead=1;

    GameObject PauseMenu;
    GameObject GameUI;
    GameObject MobileInput;
    private void Awake()
    {
        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
        MobileInput = GameObject.FindGameObjectWithTag("MobileInput");

    }
    private void Start()
    {
        controller = GetComponent<Controller>();
        health = PlayerPrefs.GetFloat("Player_Health");

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "GermSlimeBullet" && health > PlayerPrefs.GetFloat("GermSlime_Attack"))
        {
            health -= PlayerPrefs.GetFloat("GermSlime_Attack");
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "CuteVirusBullet" && health > PlayerPrefs.GetFloat("Virus_Attack"))
        {
            health -= PlayerPrefs.GetFloat("Virus_Attack");
            Debug.Log(health);

        }
        else if (other.gameObject.tag == "Mushy" && health > mashroomAttack)
        {
            health -= mashroomAttack;
            Debug.Log(health);
        }
        else if (other.gameObject.tag == "bacterium" && health > bacteriumAttack)
        {
            health -= bacteriumAttack;
            Debug.Log(health);
        }
        else
        {
            IsDead = 0;
            Debug.Log(health);
            PauseGame();
        }

    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "bacterium" && health > bacteriumAttack)
        {
            health -= bacteriumAttack;
            Debug.Log(health);
        }
        else if (collision.gameObject.tag == "GermSpike" && health > GermSpike)
        {
            health -= GermSpike;
            Debug.Log(health);
        }
        else
        {
            IsDead = 0;
            Debug.Log(health);
            PauseGame();
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
}
