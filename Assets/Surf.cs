using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surf : MonoBehaviour {

	public float boyantForce = 0.4f;
	public float boyantHeight = 2.0f;
	public float angleClamp = 25;
	public float flingForce = 20;

	bool won = false;
	Vector3 victorySpin;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (won) {
			transform.Rotate(victorySpin);
			return;
		}

		rb.AddForceAtPosition(Vector3.up * boyantForce, transform.position + transform.up * boyantHeight);

		Vector3 angles = transform.eulerAngles;
		angles.x = clampAngle(angles.x, angleClamp);
		angles.z = clampAngle(angles.z, angleClamp);
		transform.eulerAngles = angles;
	}

	public void Fling(Vector3 direction) {
		rb.AddForce(direction.normalized * flingForce);
	}

	float clampAngle(float angle, float size) {
		if (angle < 180) {
			return Mathf.Min(angle, size);
		} else {
			return Mathf.Max(angle, 360 - size);
		}
	}

	public void OnCollisionEnter(Collision other) {
		if (other.collider.CompareTag("Stage")) {
			victorySpin = rb.angularVelocity;

			rb.isKinematic = true;
			transform.parent = other.transform;
			won = true;
		}
	}
}
