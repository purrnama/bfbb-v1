﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour {

	public float punchpower = 0.03f;
	public float knockback;
	public GameObject opponent;
	public AudioSource audio;
	public AudioClip smolslap;
	public GameObject debris;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Opponent")) {
			opponent.GetComponent<David_ControllerAI> ().newhealth -= punchpower;
			Debug.Log ("Punch!");
			audio.PlayOneShot (smolslap);

			if (gameObject.name == "PunchTriggerR") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
				GameObject debrisclone = Instantiate (debris, opponent.transform.position, Quaternion.identity);

			} else if (gameObject.name == "PunchTriggerL") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
				GameObject debrisclone = Instantiate (debris, opponent.transform.position, Quaternion.identity);

			}
		}
	}
}