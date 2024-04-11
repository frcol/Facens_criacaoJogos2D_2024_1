using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : MonoBehaviour
{
    public static int vida = 5;

    private void Update()
    {
        if (vida < 0)
        {
            Destroy(gameObject);
        }
    }
    public void removeVida(int value)
    {
        vida -= value;
    }
}
