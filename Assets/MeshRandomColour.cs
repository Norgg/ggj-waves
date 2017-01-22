using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRandomColour : MonoBehaviour {
	Material material;

	void Start () {
		material = GetComponent<MeshRenderer>().material;
		Debug.Log(material);
		material.color = new Color(Random.value, Random.value, Random.value);
	}

	void FixedUpdate () {
		if (Random.value < 0.01f) {
			Debug.Log("Colour!");
			material.color = new Color(Random.value, Random.value, Random.value);
		}
	}
}
