using UnityEngine.UI;
using UnityEngine;

public class Cock : MonoBehaviour {

	public Text clock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		clock.text = ((int)Time.realtimeSinceStartup).ToString();
	}
}
