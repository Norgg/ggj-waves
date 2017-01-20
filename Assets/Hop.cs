using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {
	float hopTime = 0.0f;

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
			GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
			hopTime = 4.0f;
		}
	}
}
