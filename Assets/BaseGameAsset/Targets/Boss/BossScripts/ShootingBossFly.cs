using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBossFly : MonoBehaviour
{

    public void ShootPlayer()
    {

        GameObject bullet = ObjectPooling.SharedInstance.GetPooledObject();

        bullet.SetActive(true);
        bullet.transform.position = this.gameObject.transform.position;
        bullet.transform.localScale = new Vector3(.5f, .5f, .5f);
        bullet.tag = "BossFlyBullet";

    }
}
