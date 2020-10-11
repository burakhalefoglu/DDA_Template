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
    public GameObject Key;

    void Awake()
    {
        Helpers.RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));
    }

    void Start()
    {
        if(DestroyedEffect)
            PoolSystem.Instance.InitPool(DestroyedEffect, 16);
        
        m_CurrentHealth = SelectHealth(this.gameObject.tag);
        if(IdleSource != null)
            IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);
    }

    public void Got(float damage)
    {
        Debug.Log("Canım yandı");
        m_CurrentHealth -= damage;
        Debug.Log(m_CurrentHealth);
        
        if(m_CurrentHealth > 0)
            return;

        Vector3 position = transform.position;
        Instantiate(Key, transform.position, transform.rotation);

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
            return PlayerPrefs.GetFloat("DifficultyLevel")*1.5f;

        }
        else
        {
            return 1.0f;
        }
    }
}
