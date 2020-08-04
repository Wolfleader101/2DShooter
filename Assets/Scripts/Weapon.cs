using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public float BulletYOffset;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    } 

    void Shoot()
    {
        Vector3 pos = firePoint.position;
        pos.y += BulletYOffset;
        Instantiate(bullet, pos, firePoint.rotation);
    }
}
