using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMaker : MonoBehaviour {

	float waveProgress = 0.0f;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray)) {
				StartWave(transform.position);
			}
		}
	}

	void StartWave(Vector3 pos) {
	}
}
