using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour {
	AudioSource loop;
	AudioSource intro;

	bool starting = false;
	int startTime = 180;

	// Use this for initialization
	void Start () {
		loop = GetComponents<AudioSource>()[0];
		intro = GetComponents<AudioSource>()[1];
	}
	
	// Update is called once per frame
	void Update () {
		if (starting) {
			startTime--;
			if (startTime <= 0) {
				SceneManager.LoadScene("waves");	
			}
		}
	}

	public void LoadGame() {
		starting = true;
		loop.Stop();
		intro.Play();
	}
}
