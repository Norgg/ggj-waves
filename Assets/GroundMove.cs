using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour {
	public float startSpeed = 0.01f;
	public float maxSpeed = 0.04f;
	public float accel = 0.000001f;
	float speed;

	// Use this for initialization
	void Start () {
		speed = startSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = transform.position;
		pos.z += speed;
		speed += accel;
		speed = Mathf.Min(speed, maxSpeed);
		transform.position = pos;
	}
}
