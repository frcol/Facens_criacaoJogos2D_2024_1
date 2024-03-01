using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missle;

    private void Start()
    {
        InvokeRepeating("ShootMissle", 0, 2);
    }

    void ShootMissle()
    {
        Instantiate(missle, transform.position, Quaternion.identity);
    }
}
