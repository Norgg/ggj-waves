using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCollide : MonoBehaviour {
	public void OnCollisionEnter(Collision other) {
		GetComponentInParent<Surf>().OnCollisionEnter(other);
	}
}
