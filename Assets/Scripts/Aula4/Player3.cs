using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    public GameObject target;
    float range = 4;
    private void Start()
    {
        target.SetActive(false);
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.right * range, Color.cyan);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 4);

        if (hit.collider)
        {
            if (target.activeSelf == false)
            {
                target.SetActive(true);
            }

            target.transform.position = hit.point;
            Debug.DrawRay(hit.point, hit.normal * 4, Color.cyan);

            range = Vector2.Distance(hit.point, transform.position);
        }
        else
        {
            target.SetActive(false);
            range = 4;
        }
    }
}
