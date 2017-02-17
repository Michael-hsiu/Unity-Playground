using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpResetPosition : MonoBehaviour {


	public float speed = 2.0f;


	private Vector3 startPosition;
	private bool rotateBack = false;


	void Start() {
		startPosition = transform.position;
	}

	void Update() {

		transform.position = Vector3.Lerp(startPosition, new Vector3(startPosition.x, startPosition.y, startPosition.z - 10), (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);

		if (transform.position.z < -1.0f) {		// Set local rotation if we're in negative range on blue axis
			rotateBack = true;
		}

		//Debug.Log (rotateBack);

		if (rotateBack){
			if (transform.rotation == Quaternion.identity) {
				rotateBack = false;
			} else {
				transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, speed * Time.deltaTime);
				rotateBack = false;
			}
		} else {
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(45, 45, 45), speed * Time.deltaTime);
			//transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.identity, speed * Time.deltaTime);
			
		}

	}
}
