using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private float movePower = 5;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		// Set the maximum angular velocity.
		GetComponent<Rigidbody>().maxAngularVelocity = 25;
	}
	
	void Move(Vector3 moveDirection, bool jump)
	{
		rb.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*movePower);

		if (Physics.Raycast(transform.position, -Vector3.up, 1f) && jump)
		{
			// ... add force in upwards.
			rb.AddForce(Vector3.up, ForceMode.Impulse);
		}
	}

	public void increaseSpeed(float input)
	{
		//speed = input;
	}

	public void increaseMass()
	{
		rb.mass = 5;
	}

	public void cleanse()
	{
		//speed = 5.0f;
		rb.mass = 1;
	}
}