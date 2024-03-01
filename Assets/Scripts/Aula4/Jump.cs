using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool isGrounded = false;
    Rigidbody2D rb;

    public Transform feetPos;
    public float checkRadios;
    public LayerMask whatIsGround;
    public float jumpVelocity;

    [Space(10)]
    [Header("Sensivel ao botao")]
    public float fallMultiplier;
    public float lowJumpMultiplier;
    public float gravity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadios, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, transform.up.y * jumpVelocity); ;
        }
    }

    private void FixedUpdate()
    {
        if (rb.velocity.y < 0) // if is falling, accelerate
        {
            rb.velocity += Vector2.up * (-fallMultiplier);
        }
        else if(rb.velocity.y > 0 && !Input.GetButton("Jump")) // if is going up and not pressing button
        {
            rb.velocity += Vector2.up * (-lowJumpMultiplier);
        }

        if (!isGrounded)
        {
            rb.velocity += Vector2.up * (gravity);
        }
    }

    private void OnDrawGizmos()
    {
        Collider2D isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadios, whatIsGround);

        if (isGrounded)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(feetPos.position, checkRadios);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(feetPos.position, checkRadios);
        }
    }
}
