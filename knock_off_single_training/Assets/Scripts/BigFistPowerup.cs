using UnityEngine;
using System.Collections;

public class BigFistPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			//Debug.Log ("collision", other.gameObject.name);
			other.GetComponent<Fist> ().makeFistBig();

			Destroy (this.gameObject);
		}
	}
}
