using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {

	public float hopStrength = 300;
	public float startRandomJumpChance = 0.0001f;
	public float maxRandomJumpChance = 0.0005f;
	public float randomJumpStrength = 0.5f;
	float randomJumpChance;
	float randomJumpChanceSpeed = 0.0000001f;
	bool grounded;
	Material material;

	// Use this for initialization
	void Start () {
		material = GetComponentInChildren<SkinnedMeshRenderer>().material;
		material.color = new Color(Random.value, Random.value, Random.value);
		randomJumpChance = startRandomJumpChance;
	}
	
	void FixedUpdate () {
		randomJumpChance += randomJumpChanceSpeed;
		randomJumpChance = Mathf.Min(maxRandomJumpChance, randomJumpChance);
		if (Random.value < randomJumpChance) {
			Jump(Random.value * randomJumpStrength);
		}
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
