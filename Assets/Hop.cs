using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {

	public float hopStrength = 300;
	bool grounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Jump(float strength) {
		if (grounded) {
			GetComponent<Rigidbody>().AddForce(Vector3.up * hopStrength * strength);
		}
	}

	public void OnCollisionEnter(Collision other) {
		if (other.collider.CompareTag("ground")) {
			grounded = true;
		}
	}

	public void OnCollisionExit(Collision other) {
		if (other.collider.CompareTag("ground")) {
			grounded = false;
		}
	}
}
