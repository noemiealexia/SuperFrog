using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    static public float speed = 5;
    public float jumpForce = 5;
    private float moveInput;

    private Rigidbody2D rigidBody;

    public bool facingRight = true;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(moveInput * speed, rigidBody.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            rigidBody.velocity = Vector2.up * jumpForce;
        }

    }

    void Flip()
    {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }
}

// Help from Tutorial : https://www.youtube.com/watch?v=QGDeafTx5ug&t=365s
