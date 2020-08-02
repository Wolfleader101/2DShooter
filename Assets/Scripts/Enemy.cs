using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Transform Player;
    public int MoveSpeed = 4;
    public int TargetDistance = 2;
    public int OutOfRange = 8;

  //  public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, quaternion.identity);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Player);
        float dist = Vector2.Distance(transform.position, Player.position);
        if (dist <= TargetDistance && dist <= OutOfRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, MoveSpeed * Time.deltaTime);
        }
    }
}
