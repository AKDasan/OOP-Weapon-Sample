using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private void Start()
    {
        W_name = "Pistol";
        damage = 10f;
        bulletSpeed = 40f;
        fireRate = 1f;
    }

    private void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        } 
    }

    public override void Shoot()
    {
        base.Shoot();
    }
}
