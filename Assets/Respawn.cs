using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -4) {
			Vector3 newPos = transform.position;
			newPos.y = startPos.y;
			newPos.z += 28;
			transform.position = newPos;
		}
	}
}
