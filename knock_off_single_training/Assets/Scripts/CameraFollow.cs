using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	Vector3 offset = Vector3.zero;
	public GameObject player;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	}
}
