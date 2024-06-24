using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Rifle : Weapon
{
    private void Start()
    {
        W_name = "Rifle";
        damage = 20f;
        bulletSpeed = 70f;
        fireRate = 5f;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    public override void Shoot()
    {
        base.Shoot();
    }
}
