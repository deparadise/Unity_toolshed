using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 5f;
	public float jumpingForce = 10f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			// JUMP
			GetComponent<Rigidbody>().AddForce(0 , jumpingForce, 0);
		}

		if (Input.GetKey("left"))	{
			//
		}

		if (Input.GetKey("right")) {
			//
		}
	}
}
