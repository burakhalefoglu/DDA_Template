using System.Collections;
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

    void Awake()
    {
        Helpers.RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));

    }

    void Start()
    {
        //if(DestroyedEffect)
        //    PoolSystem.Instance.InitPool(DestroyedEffect, 16);
        
        if(IdleSource != null)
            IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);

        Player = GameObject.FindGameObjectWithTag("Player");
        character = Player.GetComponent<Character>();

      
            m_CurrentHealth = SelectHealth(this.gameObject.tag);
            FirstHealh = m_CurrentHealth;


        enemyHealthBar = UI.GetComponent<EnemyHealthBar>();

    }

    public void Got(float damage)
    {
        Debug.Log("Canım yandı");
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
            HealthBarPoint = 1 - (damage / FirstHealh);
            enemyHealthBar.SetHealthBarValue(HealthBarPoint);
            return;

        }

        Vector3 position = transform.position;

        if (DestroyedEffect != null)
        {
            var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
            effect.time = 0.0f;
            effect.Play();
            effect.transform.position = position;
        }

        m_Destroyed = true;

        gameObject.SetActive(false);

        GameSystem.Instance.TargetDestroyed(pointValue);
    }
    
    public void killyourself()
    {
        Debug.Log("kİLL mEE");
        Vector3 position = transform.position;
        var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
        effect.time = 0.0f;
        effect.Play();
        effect.transform.position = position;
        m_Destroyed = true;
        gameObject.SetActive(false);
        GameSystem.Instance.TargetDestroyed(pointValue);

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
            return PlayerPrefs.GetFloat("DifficultyLevel")*3f;

        }
        else if (tag == "BossGermSpike")
        {
            return 50;

        }
        else if (tag == "BossVirus")
        {
            return 30;

        }
        else if (tag == "BossDomestos")
        {
            return 70;

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
}
