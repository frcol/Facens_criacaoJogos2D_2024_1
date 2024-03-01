using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject[] arGo;
    float time;
    int index = 0;

    private void Start()
    {
        DropItemMethod();
    }

    void DropItemMethod()
    {
        GameObject tmp = Instantiate(arGo[index], transform.position, Quaternion.identity);
         Destroy(tmp, 3);

        index++;
        if (index >= 3)
        {
            index = 0;
        }

        time = Random.Range(1, 3);
        Invoke("DropItemMethod", time);
    }
}
