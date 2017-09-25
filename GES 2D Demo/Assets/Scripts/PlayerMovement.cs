using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRigidBody2D;
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float jumpForce = 5;
    private bool collisionCheck;

    void Start ()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (collisionCheck == true)
        {
            myRigidBody2D.velocity = new Vector2(speed * horizontalInput, myRigidBody2D.velocity.y);
        }
        /*else
        {
             myRigidBody2D.velocity += new Vector2((speed/10) * horizontalInput, 0);
        }
        */
        
        if (Input.GetButtonDown("Jump") & collisionCheck == true)
        {
            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, jumpForce);
            collisionCheck = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionCheck = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collisionCheck = false;
    }
}
