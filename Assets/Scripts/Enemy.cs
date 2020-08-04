using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : BaseEntity
{
    //public int health = 100;
    public Transform Player;
   // public int MoveSpeed = 4;
    public int TargetDistance = 2;
    public int OutOfRange = 8;
    public int damage;



   protected override void Die()
  {
      base.Die();
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
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
       Collider2D hitInfo = col.collider; 
       Player player = hitInfo.GetComponent<Player>();
       if(player != null) player.TakeDamage(damage);
       Destroy(gameObject);
    }
}
