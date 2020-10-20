using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomestosAttack : MonoBehaviour
{

   
    public void ShootPlayer()
    {
       
        GameObject bullet = ObjectPooling.SharedInstance.GetPooledObject();

        bullet.SetActive(true);
        bullet.transform.position = this.gameObject.transform.position;
        bullet.transform.localScale = new Vector3(1f,1f,1f);
        bullet.tag = "DomestosBullet";

    }
}
