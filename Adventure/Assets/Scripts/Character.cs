using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float speed=4.0f;
    public Rigidbody2D rb;
    public float jumpForce = 100.0f;
    public bool onGround = true;
    public SpriteRenderer sprite;
    public Animator charAnimator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charAnimator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Ground")
            onGround = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Ground")
            onGround = false;
    }
    void Update()
    {
        if(Input.GetButton("Horizontal")){
            Vector3 tempvector = Vector3.right * Input.GetAxis("Horizontal");
            transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector,
                speed * Time.deltaTime);
            if (tempvector.x < 0)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) &&onGround)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
