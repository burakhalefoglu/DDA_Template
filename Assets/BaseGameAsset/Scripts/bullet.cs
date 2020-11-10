using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField]
    float thrust = 1.0f;
    float time = 0;
    Vector3 shoot;
    GameObject target;
    Material m_Material;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rigidbody = GetComponent<Rigidbody>();
        m_Material = GetComponent<Renderer>().material;
        ChangeMaterialColor();

    }



    void FixedUpdate()
    {
       
            shoot = (target.transform.localPosition - transform.localPosition).normalized;
            rigidbody.AddForce(shoot * thrust);
        
    }
    private void Update()
    {
        
        time += Time.deltaTime;
        if (time > 2f)
        {
            time = 0;
            gameObject.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isAttack = other.gameObject.tag == "Player";
        if (isAttack)
        {
            gameObject.SetActive(false);

            GameObject Particle = ObjectPooling.SharedInstance.GetPooledObject();
            Particle.transform.localPosition = this.gameObject.transform.localPosition;
            Particle.transform.rotation = this.gameObject.transform.rotation;
            Particle.SetActive(true);
        }
    }



    void ChangeMaterialColor()
    {
       
        if (this.gameObject.tag == "BossFlyBullet")
        {

            m_Material.SetColor("_Color1", new Color(220, 220,0));
            m_Material.SetColor("_Color2", new Color(200, 200,0));

        }
        else
        {
            m_Material.SetColor("_Color1", new Color(0, 220, 0));
            m_Material.SetColor("_Color2", new Color(0, 200, 0));
        }
    }


}
