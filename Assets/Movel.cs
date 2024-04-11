using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movel : MonoBehaviour {

	public Rigidbody2D rb;
	float velHor = 2f;

	void Start () {
		
	}
	
	void Update () {
		rb.MovePosition(new Vector2(transform.position.x + velHor*Time.deltaTime, 0));

		if (transform.position.x > 2.75f && velHor > 0)
		{
			velHor *= -1;
		} else if (transform.position.x < -2.75f && velHor < 0)
		{
			velHor *= -1;
		}
	}
}
