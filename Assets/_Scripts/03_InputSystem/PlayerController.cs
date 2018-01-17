using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			// JUMP
			Debug.Log("SPACE BAR!");
		}

		if (Input.GetKey("left"))	{
			//
		}

		if (Input.GetKey("right")) {
			//
		}
	}
}
