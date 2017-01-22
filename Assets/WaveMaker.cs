using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMaker : MonoBehaviour {

	class Wave {
		public Vector3 pos;
		public float progress = 0;

		public Wave(Vector3 pos) {
			this.pos = pos;
		}
	}

	public float waveDuration = 5.0f;
	public float waveSpeed = 0.1f;
	bool doWave = false;
	List<Wave> waves = new List<Wave>();
	int maxWaves = 3;

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

		List<Wave> done = new List<Wave>();

		foreach (Wave wave in waves) {
			wave.progress += waveSpeed;
			if (wave.progress > waveDuration) {
				done.Add(wave);
			}

			float waveStrength = 1.0f - wave.progress / waveDuration;

			foreach (Collider obj in Physics.OverlapSphere(wave.pos, wave.progress)) {
				Hop hop = obj.GetComponent<Hop>();
				if (hop != null) {
					hop.Jump(waveStrength);
				}

				Surf surf = obj.GetComponentInParent<Surf>();
				if (surf != null) {
					surf.Fling((obj.transform.position - wave.pos) * waveStrength);
				}
			}
		}

		foreach (Wave wave in done) {
			waves.Remove(wave);
		}
	}

	void StartWave(Vector3 pos) {
		if (waves.Count > maxWaves) {
			waves.RemoveAt(0);
		}
		waves.Add(new Wave(pos));
	}
}
