using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling SharedInstance;

    [SerializeField]
    GameObject objectBullet;

    [SerializeField]
    GameObject objectParticle;

    [SerializeField]
    GameObject objectVirusBullet;


    float amountToPool = 5;

    public List<GameObject> pooledBullet;
    public List<GameObject> pooledVirusBullet;
    public List<GameObject> pooledParticle;

    private void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledBullet = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectBullet);
            obj.SetActive(false);
            pooledBullet.Add(obj);
        }


        pooledParticle = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectParticle);
            obj.SetActive(false);
            pooledParticle.Add(obj);
        }

        pooledVirusBullet = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectVirusBullet);
            obj.SetActive(false);
            pooledVirusBullet.Add(obj);
        }

    }

    public GameObject GetPooledObject()
    {
        
        for (int i = 0; i < pooledBullet.Count; i++)
        {
            
            if (!pooledBullet[i].activeInHierarchy)
            {
                return pooledBullet[i];
            }
        }
         GameObject newobject = Instantiate(objectBullet);
        pooledBullet.Add(newobject);
        return newobject;
    }


    public GameObject GetPooledParticle()
    {

        for (int i = 0; i < pooledParticle.Count; i++)
        {

            if (!pooledParticle[i].activeInHierarchy)
            {
                return pooledParticle[i];
            }
        }
        GameObject newobject = Instantiate(objectParticle);
        pooledParticle.Add(newobject);
        return newobject;
    }

    public GameObject GetPooledVirusBullet()
    {

        for (int i = 0; i < pooledVirusBullet.Count; i++)
        {

            if (!pooledVirusBullet[i].activeInHierarchy)
            {
                return pooledVirusBullet[i];
            }
        }
        GameObject newobject = Instantiate(objectVirusBullet);
        pooledVirusBullet.Add(newobject);
        return newobject;
    }



}
