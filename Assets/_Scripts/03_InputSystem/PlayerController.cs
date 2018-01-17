using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 5f;
	public float rotateSpeed = 60f;
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

		if (Input.GetKey("up")) {
			// advance
			transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey("down")) {
			// withdraw
			transform.position += Vector3.back * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey("left"))	{
			// strafe L
			transform.position += Vector3.left * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey("right")) {
			// strafe R
			transform.position += Vector3.right * moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey("q")) {
			// rotate L
			transform.RotateAround(transform.position, Vector3.up, -rotateSpeed * Time.deltaTime);
		}

		if (Input.GetKey("e")) {
			// rotate L
			transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision collided) {
		if(collided.transform.name == "Floor") {
			canJump = true;
		}
	}
}
