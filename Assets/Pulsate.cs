using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsate : MonoBehaviour {
	Vector3 startScale;
	float t = 0;

	// Use this for initialization
	void Start () {
		startScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		t += 0.15f;
		transform.localScale = startScale * (1.0f + 0.01f * Mathf.Sin(t));
	}
}
