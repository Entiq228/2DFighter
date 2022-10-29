using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool doJump;
    private float moveInput;

    private bool facingRight = true;
    public float timeBlock;
    public float Block;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (!facingRight && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight && moveInput < 0)
        {
            Flip();
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !doJump)
        {
            rb.AddForce(Vector3.up * jumpForce);
            doJump = true;
        }
        timeBlock += Time.deltaTime;
        if (timeBlock >= Block)
        {
            doJump = false;
            timeBlock = 0;
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
