using UnityEngine;
using System.Collections;

public class HeavyMassPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			//Debug.Log ("collision", other.gameObject.name);
			other.GetComponent<PlayerController>().increaseMass();
			Destroy (this.gameObject);
		}
	}
}
