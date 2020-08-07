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
    private bool canReload = false;
    public float reloadTime = 1.2f;

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
            canReload = true;
            if (currentAmmo >= 0)
            {
                ammo.setAmmo(currentAmmo);
                Shoot();
            }
        }
        
        if(currentAmmo == maxAmmo) canReload = false;

        if (Input.GetKeyDown ("r") && canReload == true) {
            StartCoroutine( Reload(reloadTime) );
        }
    } 

    IEnumerator Reload(float time) {
        canReload = false;

        yield return new WaitForSeconds(time);
        currentAmmo = maxAmmo;
        ammo.setAmmo(currentAmmo);
        canReload = true;
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
