using UnityEngine;
using System.Collections;

public class FastSpeedPowerup: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Ball ball = other.GetComponent<Ball> ();
			ball.increaseSpeed (7.5f);
			Destroy (this);
		}
	}
}
