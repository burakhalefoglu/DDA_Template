using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    GameObject Player;
    Controller controller;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        controller = Player.GetComponent<Controller>();
    }


   public void Attack()
    {
        controller.shoot();
    }

    public void ChangeWeaponright()
    {
        controller.changeWeaponRight();
    }

    public void ChangeWeaponLeft()
    {
        controller.changeWeaponLeft();
    }

    public void Jump()
    {
        controller.Jump();
    }

}
