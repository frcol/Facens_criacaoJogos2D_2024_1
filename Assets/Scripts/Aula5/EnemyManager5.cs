using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager5 : MonoBehaviour
{
    public Enemy5 enemy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.removeVida(1);
        }
    }

    public void DestroyAll()
    {
        
    }
}
