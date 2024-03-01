using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector2 direction = Vector2.right * hor;
        rb.velocity = new Vector2(direction.x*speed, rb.velocity.y);
    }
}
