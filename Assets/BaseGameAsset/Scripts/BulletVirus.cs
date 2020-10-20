using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVirus : MonoBehaviour
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
        Debug.Log("Doğdum");
        target = GameObject.FindGameObjectWithTag("Player");
        rigidbody = GetComponent<Rigidbody>();

    }



    void FixedUpdate()
    {
       
        shoot = (target.transform.position - transform.position).normalized;
        rigidbody.AddForce(thrust*shoot);
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
        }
    }


}
