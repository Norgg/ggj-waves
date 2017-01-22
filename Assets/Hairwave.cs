using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hairwave : MonoBehaviour {

	float t = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		t += 0.1f;
		transform.rotation *= Quaternion.Euler(0, 0.8f * Mathf.Cos(t), 0);
	}
}
