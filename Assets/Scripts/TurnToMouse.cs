using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToMouse : MonoBehaviour {

	public GameObject target;
	public float sensitivityFactor = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Mouse logic
		float mouseX = Input.GetAxis("Mouse X");	// Get input


		// Turn player to mouse
		Vector3 newRotation = transform.localEulerAngles;

		//newRotation.x += mouseX * sensitivityFactor;	// Roll
		//newRotation.y += mouseX * sensitivityFactor;	// Pitch
		newRotation.z += mouseX * sensitivityFactor;	// Yaw

		transform.localEulerAngles = newRotation;

	}
}
