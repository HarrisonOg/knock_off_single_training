using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	private Ball ball;
	private Vector3 move;
	private bool jump;


	// Use this for initialization
	void Start () {
		ball = GetComponent<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
