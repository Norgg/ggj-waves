using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {

	public float hopStrength = 300;
	bool grounded;
	Material material;

	// Use this for initialization
	void Start () {
		material = GetComponentInChildren<SkinnedMeshRenderer>().material;
		material.color = new Color(Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Jump(float strength) {
		if (grounded) {
			GetComponent<Rigidbody>().AddForce(Vector3.up * hopStrength * strength);
			if (strength > 0.4f) {
				material.color = new Color(Random.value, Random.value, Random.value);
			}
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
