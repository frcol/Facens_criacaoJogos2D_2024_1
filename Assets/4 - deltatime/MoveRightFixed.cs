using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightFixed : MonoBehaviour {
	public float x = 0.0018f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(1f * Time.deltaTime, 0, 0);
	}

	private void FixedUpdate()
	{
        // 1 m/s
		transform.Translate(x, 0, 0);
	}


}
