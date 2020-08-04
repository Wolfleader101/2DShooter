using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : BaseEntity
{
    public Transform player;
    public int targetDistance = 2; 
    public int outOfRange = 8;
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
        float dist = Vector2.Distance(transform.position, player.position);
        if (dist <= targetDistance && dist <= outOfRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
       Collider2D hitInfo = col.collider; 
       Player hitPlayer = hitInfo.GetComponent<Player>();
       if(hitPlayer != null) hitPlayer.TakeDamage(damage);
       Destroy(gameObject);
    }
}
