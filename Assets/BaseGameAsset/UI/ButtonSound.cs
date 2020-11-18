using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip MainMenuSound;
    GameObject Camera;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void MainMenuTabToScreen()

    {

        audioSource.clip = MainMenuSound;
        audioSource.Play();
        Camera.GetComponent<AudioSource>().enabled = false;
    }
}
