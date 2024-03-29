﻿using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float speed = 10;
    
    //  public GameObject deatheffectSprite;
    public GameObject damageEffect;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void TakeDamage(int damage)
    {
        GameObject effect = Instantiate(damageEffect, transform.position, quaternion.identity);
        
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    protected virtual void Die()
    {
        //Instantiate(deatheffectSprite, transform.position, quaternion.identity);
    }
}
