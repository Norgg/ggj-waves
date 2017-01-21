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
		GetComponent<Rigidbody>().AddForceAtPosition(Vector3.up * boyantForce, transform.position + transform.up * boyantHeight);

		Vector3 angles = transform.eulerAngles;
		angles.x = clampAngle(angles.x, 15);
		angles.z = clampAngle(angles.z, 15);
		transform.eulerAngles = angles;
	}

	float clampAngle(float angle, float size) {
		if (angle < 180) {
			return Mathf.Min(angle, size);
		} else {
			return Mathf.Max(angle, 360 - size);
		}
	}
}
