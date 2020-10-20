using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher : MonoBehaviour
{

    ListeninCharBehavior listeninCharBehavior;
    DataAccess dataAccess;
    BoxCollider boxCollider;
    GameObject FinishUI;
    float point;
    GameObject player;
    Character character;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        character = player.GetComponent<Character>();
        FinishUI = GameObject.FindGameObjectWithTag("SucceesLevel");
        boxCollider = this.gameObject.GetComponent<BoxCollider>();
        boxCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject player = other.gameObject;
            Character character = player.GetComponent<Character>();
            listeninCharBehavior = this.gameObject.transform.GetChild(0).gameObject.GetComponent<ListeninCharBehavior>();
            dataAccess = this.gameObject.transform.GetChild(0).gameObject.GetComponent<DataAccess>();

            listeninCharBehavior.SetPlayerFinishHealth((int)character.GetPlayerHealth());
            listeninCharBehavior.SetPlayerTotalAttackCount((int)character.GetTotalAttack());
            listeninCharBehavior.SetPlayerTotalOnHit((int)character.GetTotalHit());
            listeninCharBehavior.SetPlayerDeadInformation((int)character.GetPlayerDeadInformation());
            dataAccess.verileriekle();
            float RemainHealth = character.GetPlayerHealth();
            float PlayerHealth = PlayerPrefs.GetFloat("Player_Health");
            float flow= 100-((100* RemainHealth)/ PlayerPrefs.GetFloat("Player_Health"));
            PlayerPrefs.SetFloat("Player_Flow", flow);


            float point = PlayerPrefs.GetFloat("Point");
            point += character.Getpoint();
            PlayerPrefs.SetFloat("Point", point);


            FinishUI.SetActive(true);
            PlayerPrefs.SetFloat("CurrentLevel", SceneManager.GetActiveScene().buildIndex + 1);

        }
    }





}
