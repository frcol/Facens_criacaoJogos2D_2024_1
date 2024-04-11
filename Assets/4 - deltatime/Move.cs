using UnityEngine;

public class Move : MonoBehaviour {

	public Rigidbody2D rg;

	void Start () {
		float x = Random.Range(-100, 100);
		float y = Random.Range(-100, 100);

		rg.AddForce(new Vector2(x,y));
	}
}
