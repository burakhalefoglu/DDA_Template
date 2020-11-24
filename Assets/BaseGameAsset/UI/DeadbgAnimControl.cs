using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadbgAnimControl : MonoBehaviour
{
    Character character;
    bool IsAnimStart=false;
    float playerhealth;
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        playerhealth = PlayerPrefs.GetFloat("Player_Health");
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsAnimStart && character.GetPlayerHealth() < playerhealth / 2)
        {
            IsAnimStart = true;
            GetComponent<Animator>().SetBool("BeforeDying", true);
        }
        
    }
}
