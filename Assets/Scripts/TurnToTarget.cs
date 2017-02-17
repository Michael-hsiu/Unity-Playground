using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToTarget : MonoBehaviour {

	// Target we wish to turn towards
	public Transform target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePos = target.position - transform.position;		// Find vector difference between relative positions
		Quaternion rotation = Quaternion.LookRotation(relativePos);	// Find the quaternion rotation difference
		transform.rotation = rotation;		// Change our rotation
	}
}
