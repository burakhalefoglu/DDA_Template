﻿using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Target : MonoBehaviour
{
    public int pointValue;
    public ParticleSystem DestroyedEffect;
    [Header("Audio")]
    public RandomPlayer HitPlayer;
    public AudioSource IdleSource;
    
    public bool Destroyed => m_Destroyed;

    bool m_Destroyed = false;
    float m_CurrentHealth;

    GameObject Player;
    Character character;
    float HealthBarPoint;
    float FirstHealh;

    EnemyHealthBar enemyHealthBar;

   public GameObject UI;

    AudioSource[] randomSound;
    public AudioClip[] audioClips;

    void Awake()
    {
        Helpers.RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));
        HealthBarPoint = 1;

    }

    void Start()
    {
        
        if(IdleSource != null)
            IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);

        Player = GameObject.FindGameObjectWithTag("Player");
        character = Player.GetComponent<Character>();

      
            m_CurrentHealth = SelectHealth(this.gameObject.tag);
            FirstHealh = m_CurrentHealth;


        enemyHealthBar = UI.GetComponent<EnemyHealthBar>();
        randomSound = GetComponents<AudioSource>();
   
  

    }
    private void Update()
    {
        
    }

    public void Got(float damage)
    {

        randomSound[1].Play();

        m_CurrentHealth -= damage;

        if (this.gameObject.tag == "BloodGuard")
        {
            damage *= 3;
            character.SetPoint(damage);
        }
        else
        {
            character.SetPoint(damage);
        }

       


        if (m_CurrentHealth > 0)
        {
            HealthBarPoint -= (damage / FirstHealh);
            enemyHealthBar.SetHealthBarValue(HealthBarPoint);
            return;

        }

        Vector3 position = transform.position;
        AudioSource.PlayClipAtPoint(audioClips[Random.Range(0,audioClips.Length-1)], Player.transform.position);

        //if (DestroyedEffect != null)
        //{
        //    var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
        //    effect.time = 0.0f;
        //    effect.Play();
        //    effect.transform.position = position;
        //}
        if (this.gameObject.tag == "Blood")
        {
            Destroy(this.gameObject);
        }

        gameObject.SetActive(false);

        //GameSystem.Instance.TargetDestroyed(pointValue);
    }
    
    public void killyourself()
    {
        //Vector3 position = transform.position;
        //var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
        //effect.time = 0.0f;
        //effect.Play();
        //effect.transform.position = position;
        m_Destroyed = true;
        gameObject.SetActive(false);
        //GameSystem.Instance.TargetDestroyed(pointValue);

    }

    private float SelectHealth(string tag)
    {


        if (tag == "Virus")
        {
            return PlayerPrefs.GetFloat("Virus_Health");
        }
        else if (tag == "GermSlim")
        {
            return PlayerPrefs.GetFloat("GermSlime_Health");

        }
        else if (tag == "GermSpike")
        {
            return PlayerPrefs.GetFloat("GermSpike_Health");

        }
        else if (tag == "BloodGuard")
        {
            return 10;

        }

        else if (tag == "BossEnemyFly")
        {
            return 30;

        }

        else if (tag == "BossVirus")
        {
            return 45;

        }

        else if (tag == "BossGermSpike")
        {
            return 55;

        }
        
       
        else if (tag == "BossDomestos")
        {
            return 65;

        }

         else if (tag == "BossFootMicrobe")
         {
            return 100;

         }

        else if (tag == "CuteBaby")
        {
            return 2;

        }
        else
        {
            return 1.0f;
        }
    }

    public float GetCurrentHealth()
    {
        return m_CurrentHealth;
    }
}
