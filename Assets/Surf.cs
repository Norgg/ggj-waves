using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surf : MonoBehaviour {

	public float boyantForce = 0.4f;
	public float boyantHeight = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().AddForceAtPosition(Vector3.up * boyantForce, transform.position + Vector3.up * boyantHeight);
	}
}
