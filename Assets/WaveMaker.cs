using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMaker : MonoBehaviour {

	public float waveDuration = 5.0f;
	public float waveSpeed = 0.1f;
	float waveProgress = 0.0f;
	bool waveStarted = false;
	bool doWave = false;
	Vector3 wavePos;

	// Use this for initialization
	void Start() {
		
	}

	void Update() {
		if (Input.GetButtonDown("Fire1")) {
			doWave = true;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (doWave) {
			doWave = false;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo)) {
				StartWave(hitInfo.point);
			}
		}

		if (waveStarted) {
			waveProgress += waveSpeed;
			if (waveProgress > waveDuration) {
				waveStarted = false;
			}

			foreach (Collider obj in Physics.OverlapSphere(wavePos, waveProgress)) {
				Hop hop = obj.GetComponent<Hop>();
				if (hop != null) {
					hop.Jump(1.0f - waveProgress / waveDuration);
				}
			}
		}
	}

	void StartWave(Vector3 pos) {
		waveStarted = true;
		this.waveProgress = 0.0f;
		this.wavePos = pos;
	}
}
