using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 200.0f;
    // Start is called before the first frame update
    public void Start()
    {
        // This give it a random start direction launch
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * speed);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Reset()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        Start();
    }

}
