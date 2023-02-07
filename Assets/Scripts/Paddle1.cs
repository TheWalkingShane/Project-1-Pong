using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rb;
    public float speed = 10f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        float horizontalVal = Input.GetAxis("Horizontal");
        direction = Vector2.up * horizontalVal;
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rb.AddForce(direction * speed);
        }
    }
    
    public void Reset()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }
}
