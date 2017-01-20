using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {
	float hopTime = 0.0f;

	public float hopStrength = 300;
	public float maxHopTime = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hopTime > 0) {
			hopTime -= Time.deltaTime;
		}
	}

	public void Jump() {
		if (hopTime <= 0) {
			GetComponent<Rigidbody>().AddForce(Vector3.up * hopStrength);
			hopTime = maxHopTime;
		}
	}
}
