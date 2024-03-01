using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula2 : MonoBehaviour
{
    public GameObject go;
    SpriteRenderer sp;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            sp.enabled = !sp.enabled;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            go.SetActive(!go.activeSelf);
        }
    }
}
