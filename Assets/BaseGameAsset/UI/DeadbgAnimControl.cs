using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadbgAnimControl : MonoBehaviour
{
    Character character;
    bool IsAnimStart=false;
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsAnimStart && character.GetPlayerHealth() < 30)
        {
            IsAnimStart = true;
            GetComponent<Animator>().SetBool("BeforeDying", true);
        }
        
    }
}
