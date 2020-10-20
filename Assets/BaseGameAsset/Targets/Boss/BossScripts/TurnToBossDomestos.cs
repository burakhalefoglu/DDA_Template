using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToBossDomestos : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    [SerializeField]
    float maxdistance = 20;
    [SerializeField]
    float rotationSpeed = 0.1f;
    float angle;
    DomestosAttack domestosAttack;

    float time = 0;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxdistance = 200;

        domestosAttack = GetComponent<DomestosAttack>();

    }


    void Update()
    {
        time += Time.deltaTime;

        Debug.DrawLine(target.position, myTransform.position, Color.red);
        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
                                               Quaternion.LookRotation(myTransform.position- target.position),
                                               rotationSpeed * Time.deltaTime);

            Vector3 targetDir = target.position - transform.position;
            angle = Vector3.Angle(targetDir, transform.forward);

            if (angle > 160 && time>3f)
            {
                time = 0;
                domestosAttack.ShootPlayer();
            }

        }
    }
}
