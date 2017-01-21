using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
	public GameObject player;
	public Vector3 offset = Vector3.up;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos = player.transform.position + offset;
		pos.x = 0;
		transform.position = pos;

		//transform.LookAt(player.transform);
	}
}
