using UnityEngine;
using System.Collections;

public class Fist : MonoBehaviour {

	public float punchPower = 20;
	private Rigidbody rb;
	Vector3 offset = new Vector3(0f, 0f, 0f);
	Vector3 playerPos = new Vector3(0f,0f,0f);

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		playerPos = transform.parent.transform.position;
		offset = transform.position - playerPos;
	}

	public void Punch (Vector3 input, bool toDo) {
		if (toDo) {
			rb.AddForce (input * punchPower);
		} else {
			transform.position = playerPos + offset;
		}
	}
}
