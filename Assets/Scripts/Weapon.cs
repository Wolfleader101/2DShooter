using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Bullet bulletPrefab;
    public float BulletYOffset;

    public Ammo ammo;
    public int maxAmmo = 10;
    public int currentAmmo = 0;

    public Reload reloadPrefab;
    public float reloadTime = 1.2f;

    private bool canShoot;
    private bool canReload = false;
    
    public Canvas canvas;

    private void Start()
    {
        canShoot = true;
        currentAmmo = maxAmmo;
        ammo.setMaxAmmo(maxAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.rotation = Quaternion.identity;
        if (Input.GetButtonDown("Fire1") && canShoot)
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
        canShoot = false;
        Reload newReload = Instantiate(reloadPrefab, transform.position, transform.rotation);
        newReload.parent = canvas;
        newReload.timeAmount = reloadTime;
        
        yield return new WaitForSeconds(time);
        currentAmmo = maxAmmo;
        ammo.setAmmo(currentAmmo);
        canShoot = true;
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
