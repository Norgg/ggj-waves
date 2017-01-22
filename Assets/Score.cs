using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public GameObject player;
	float score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		score += player.GetComponent<Rigidbody>().velocity.magnitude/10.0f;
		GetComponent<TextMesh>().text = "" + (int)score;
	}

	public void Double() {
		score *= 2;
	}
}
