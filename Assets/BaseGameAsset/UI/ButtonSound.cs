using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip MainMenuSound;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void MainMenuTabToScreen()

    {

        audioSource.clip = MainMenuSound;
        audioSource.Play();

    }
}
