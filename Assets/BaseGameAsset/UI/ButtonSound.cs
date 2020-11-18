using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{

    AudioSource audioSource;
    GameObject Camera;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void MainMenuTabToScreen()

    {
        audioSource.Play();
        Camera.GetComponent<AudioSource>().enabled = false;
    }
}
