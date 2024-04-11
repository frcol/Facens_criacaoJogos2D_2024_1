using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBox : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D collision)
	{
		print(Time.realtimeSinceStartup);

		//Time.timeScale = 0;
	}
}
