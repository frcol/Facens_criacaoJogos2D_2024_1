using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// em condições normais roda a 60 fps que é igual a 10 m/s
		// transform.Translate(0.01666f, 0, 0);
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
