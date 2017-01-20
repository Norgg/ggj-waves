using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMaker : MonoBehaviour {

	float waveProgress = 0.0f;
	bool waveStarted = false;
	Vector3 wavePos;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Debug.Log("Click");
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo)) {
				StartWave(hitInfo.point);
				Debug.Log("Hit");
			}
		}

		if (waveStarted) {
			waveProgress += 0.1f;
			if (waveProgress > 5.0f) {
				waveStarted = false;
			}

			Debug.Log(waveProgress);

			foreach (Collider obj in Physics.OverlapSphere(wavePos, waveProgress)) {
				Hop hop = obj.GetComponent<Hop>();
				Debug.Log(obj);
				if (hop != null) {
					hop.Jump();
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
