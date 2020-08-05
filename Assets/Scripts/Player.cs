using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : BaseEntity
{
    public HealthBar HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        HealthBar.SetHealth(currentHealth);
    }

    protected override void Die()
    {
        base.Die();
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
