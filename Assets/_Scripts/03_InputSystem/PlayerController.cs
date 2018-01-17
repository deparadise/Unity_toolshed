using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 5f;
	public float jumpingForce = 400f;
	public bool canJump = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && canJump) {
			canJump = false;
			GetComponent<Rigidbody>().AddForce(0 , jumpingForce, 0);
		}

		if (Input.GetKey("left"))	{
			//
		}

		if (Input.GetKey("right")) {
			//
		}
	}

	void OnCollisionEnter (Collision collided) {
		if(collided.transform.name == "Floor") {
			canJump = true;
		}
	}
}
