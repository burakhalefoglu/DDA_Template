using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField]
    float health;
    float mashroomAttack = 1;
    float bacteriumAttack = 1;
    float GermSpike = 5;
    [SerializeField]
    GameObject pausePanel;
    Controller controller;


    private void Start()
    {
        controller = GetComponent<Controller>();
        health = PlayerPrefs.GetFloat("Player_Health")*10;

    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "GermSlimeBullet" && health> PlayerPrefs.GetFloat("GermSlime_Attack"))
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
        else
        {
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
            Debug.Log(health);
            PauseGame();
        }
    }

    private void PauseGame()
    {
        controller.DisplayCursor(true);
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

  
}
