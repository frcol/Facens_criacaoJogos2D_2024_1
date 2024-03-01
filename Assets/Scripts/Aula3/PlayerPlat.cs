using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlat : MonoBehaviour
{
    public float speed = 5;

    Rigidbody2D rb;
    float hor;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        Vector2 direction = Vector2.right * hor;
        rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);
    }
}
