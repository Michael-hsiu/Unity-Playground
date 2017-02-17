using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour {

	// In this example we show how to invoke a coroutine and 
	// continue executing the function in parallel.

	public GameObject missile;
	public float missileDelay = 3.0f;

	private IEnumerator coroutine;
	private int numMissiles = 0;

	void Start() {
		coroutine = WaitAndFire(missileDelay);	// Assign co-routine
		StartCoroutine(coroutine);	// Begin eternal missile launch
	}

	private IEnumerator WaitAndFire(float missileDelay) {
		while (numMissiles < 10) {
			Instantiate (missile, transform.position, Quaternion.identity);
			numMissiles += 1;

			print ("Missile # " + numMissiles + " launched!");

			yield return new WaitForSeconds (missileDelay);

			print ("DELAY ENDED!");
		}
	}
}
