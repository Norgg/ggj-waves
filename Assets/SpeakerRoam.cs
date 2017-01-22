using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerRoam : MonoBehaviour {

	public float speed = 1f;
	float t;

	void Start () {
	}
	
	void Update () {
		t += 0.003f;
		transform.position += new Vector3(speed * Mathf.Cos(t), 0, 0.01f);
	}
}
