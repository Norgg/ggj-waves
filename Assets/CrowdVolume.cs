using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdVolume : MonoBehaviour {

	public Rigidbody player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<AudioSource>().volume = 0.3f + player.velocity.magnitude / 10.0f;
	}
}
