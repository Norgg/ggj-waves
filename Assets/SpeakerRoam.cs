using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerRoam : MonoBehaviour {

	public float speed = 1f;
	Rigidbody rb;
	float t;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		t += 0.03f;
		transform.position += new Vector3(speed * Mathf.Cos(t), 0, 0);
	}
}
