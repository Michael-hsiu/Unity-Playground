using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissileMovement : MonoBehaviour {

	public Transform target;
	public Vector3 startPos;

	public float missileVelocity = 10.0f;
	public float rotationSpeed = 1.0f;

	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		//if (Input.GetButtonDown("Fire1")) {
			Vector3 dist = target.position - transform.position;
			Quaternion rotation = Quaternion.LookRotation(dist);

			transform.rotation = rotation;
			//rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed));
			rb.velocity = transform.forward * missileVelocity;
		//}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Target")) {
			//rb.velocity = Vector3.zero;
			Debug.Log ("TARGET HIT!");

			transform.position = new Vector3 (transform.position.x + Random.Range(-20.0f, 20.0f), 
									transform.position.y + Random.Range(-20.0f, 20.0f), transform.position.z + Random.Range(-20.0f, 20.0f));
		}
	}
}
