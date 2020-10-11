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

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rigidbody = GetComponent<Rigidbody>();
    }


  
    void FixedUpdate()
    {
        shoot = (target.transform.position - transform.position).normalized;
        rigidbody.AddForce( shoot * thrust);
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
            Particle.transform.position = this.gameObject.transform.position;
            Particle.transform.rotation = this.gameObject.transform.rotation;
            Particle.SetActive(true);
        }
    }
}
