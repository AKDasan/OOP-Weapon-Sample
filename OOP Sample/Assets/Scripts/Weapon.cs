using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string W_name;
    public float damage;
    public float bulletSpeed;
    public float fireRate;

    public Transform firePoint;
    public GameObject bulletPrefab;

    protected float nextFireTime;
    
    public virtual void Shoot()
    {
        if (bulletPrefab != null && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            GameObject bullet = Instantiate(bulletPrefab,transform.position,transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = firePoint.forward * bulletSpeed;
            }

            Destroy(bullet,3f);
        }
    }

}
