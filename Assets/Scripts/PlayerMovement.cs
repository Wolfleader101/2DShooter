using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate()
    {
        //Player movement code
        //Create a Vector2 called "movement" from the Horizonal and Vertical axis
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (x, y);

        //Use the Ridgidbody2d component to move the player in the direction of "movement" multiplied by "speed". Remember to set speed in the inspector.
       // rb.AddForce(movement * speed, ForceMode2D.Impulse);
       rb.velocity = (movement * speed);


        //Set the player's rotation to face the mouse cursor.
        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
        Vector3 rot = transform.eulerAngles;
        float angleZ =  Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90;
        rot.z = angleZ;
        transform.eulerAngles = rot;
        // Vector3 mouseScreen = Input.mousePosition;
        // Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
        //transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);


    }
}
