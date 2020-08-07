using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Bullet bulletPrefab;
    public float BulletYOffset;

    public Ammo ammo;
    public int maxAmmo = 10;
    public int currentAmmo = 0;

    private void Start()
    {
        currentAmmo = maxAmmo;
        ammo.setMaxAmmo(maxAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentAmmo--;
            if (currentAmmo >= 0)
            {
                ammo.setAmmo(currentAmmo);
                Shoot();
            }
        }
    } 

    void Shoot()
    {
        Vector3 pos = firePoint.position;
        pos.y += BulletYOffset;
        Bullet newBullet = Instantiate(bulletPrefab, pos, firePoint.rotation);
        Player player = this.GetComponent<Player>();
        newBullet.player = player;
    }
}
