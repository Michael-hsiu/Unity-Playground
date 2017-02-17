using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour {

	public float smoothing = 7.0f;
	public Vector3 Target {
		
		get { 
			return target; 
		}

		set {
			target = value;

			StopCoroutine ("Movement");		// Stop all existing Movement coroutines
			StartCoroutine ("Movement", target);		// Begin coroutine
		}
	}


	private Vector3 target;


	IEnumerator Movement(Vector3 target) {
		while (Vector3.Distance(transform.position, target) > 0.05f) {
			transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
			yield return null;
		} 
	}

}
