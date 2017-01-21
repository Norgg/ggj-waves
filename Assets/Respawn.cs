using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	Vector3 startPos;

	List<Vector3> targetPositions = new List<Vector3>();
	float lerpFac = 0;
	float lerpSpeed = 0.04f;
	float forwardAmount = 28;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (targetPositions.Count > 1) {
			// follow target positions in Kinematic mode if there are any
			if (!rb.isKinematic) {
				rb.isKinematic = true;
			}
			lerpFac += lerpSpeed;

			Vector3 target = Vector3.Lerp(targetPositions[0], targetPositions[1], lerpFac);
			Debug.Log(target);

			transform.position = target;
			//rb.MovePosition(target);

			if (lerpFac >= 1) {
				lerpFac = 0;
				targetPositions.RemoveAt(0);
			}
		} else {
			if (rb.isKinematic) {
				rb.isKinematic = false;
			}
			if (transform.position.y < -4) {
				targetPositions.Clear();
				targetPositions.Add(transform.position);

				Vector3 newPos = transform.position;
				newPos.z += forwardAmount / 2;
				targetPositions.Add(newPos);
				
				newPos.z += forwardAmount / 2;
				targetPositions.Add(newPos);

				newPos.y = startPos.y;
				targetPositions.Add(newPos);

				lerpFac = 0.0f;
			}
		}
	}
}
