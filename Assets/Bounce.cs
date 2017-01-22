using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {
	float t = 0;
	Vector3 startPos;
	public GameObject player;

	// Use this for initialization
	void Start () {
		startPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = startPos;
		t += 0.03f;
		pos.y += Mathf.Sin(t);
		pos.x += 1.5f * Mathf.Cos(4*t);
		transform.localPosition = pos;

		transform.LookAt(player.transform);
	}
}
