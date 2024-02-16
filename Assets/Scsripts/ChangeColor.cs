using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public bool isJumping = false;

    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isJumping)
        {
            print("Pulando...");
        }
        else
        {
            print("Nao pulando...");
        }
    }

    private void Jump()
    {
        print("Pulando....");
    }

    private void Walk()
    {
        print("Andando,..");
    }

    private void Attack()
    {
        Debug.LogWarning("Atacando...");
    }
}
