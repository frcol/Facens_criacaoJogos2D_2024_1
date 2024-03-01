using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(1, 4);
    }

    private void FixedUpdate()
    {
        rb.velocity = -1* transform.right * speed;
    }
}
