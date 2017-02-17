using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSetPosition : MonoBehaviour {

	public MoveToMouse coroutineScript;

	void OnMouseDown() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);	// Create a ray from camera to mouse click position
		RaycastHit hit;		// Struct to hold potential hit recorded by ray

		Physics.Raycast (ray, out hit);		// Send the ray and look for info

		if (hit.collider.gameObject == gameObject) {		// If ray hit us,
			coroutineScript.Target = new Vector3(hit.point.x, hit.point.y + 5, hit.point.z);			// use Properties to set the script of our MoveToMouse singleton to mouse click position!
		}
	}

}
