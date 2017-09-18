using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 0.1f;
    public float jumpForce = 2;
    private bool collisionCheck;

    void Start ()
    {

	}
	
	void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed * horizontalInput, 0, 0);

        if (Input.GetButtonDown("Jump") & collisionCheck == true)
        {
            transform.Translate(0, jumpForce, 0);
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
