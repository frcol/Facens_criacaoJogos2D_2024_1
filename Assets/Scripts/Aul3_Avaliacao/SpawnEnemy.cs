using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    private void Start()
    {
        Invoke("Spawn", 0);
    }

    void Spawn()
    {
        float yPos = Random.Range(-2, 4);
        Vector2 newPos = new Vector2(10, yPos);
        GameObject tmp = Instantiate(enemy, newPos, Quaternion.identity, transform);

        float time = Random.Range(2, 6);
        Invoke("Spawn", time);
    }
}
