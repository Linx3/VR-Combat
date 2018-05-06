/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class move : MonoBehaviour {

	private bool walking = false;
	private Vector3 spawnPoint;


	// Use this for initialization
	void Start () {

		spawnPoint = transform.position;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.position);


		if (walking) {

			transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;

		}

		if (transform.position.y < -10f) {

			transform.position = spawnPoint;
		}

		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		Debug.Log(ray);



		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.name.Contains ("Plane")) {
				Debug.Log ("florr");
				walking = false;
			} else {
				walking=true;

			}
		}
	}
}


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRLookWalk : MonoBehaviour {

	public Transform vrCamera;

	public float toggleAngle = 30.0f;

	public float speed = 3.0f;

	public bool moveForward;

	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
			moveForward = false;
		} else {
			moveForward = true;
		}
		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}







*/






/*   working version that goes throu floor

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class move : MonoBehaviour {

	private bool walking = false;
	private Vector3 spawnPoint;


	// Use this for initialization
	void Start () {

		spawnPoint = transform.position;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.position);


		if (walking) {

			//transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;

			//rb.velocity= GameObject.Find("GvrReticlePointer").transform.forward * 40;
			//transform.position = transform.position + GameObject.Find("GvrReticlePointer").transform.forward * .5f * Time.deltaTime;
			transform.position = transform.position + GameObject.Find("Camera").transform.forward * .5f * Time.deltaTime;



		}

		if (transform.position.y < -10f) {

			transform.position = spawnPoint;
		}

			
		if (GameObject.Find("Camera").transform.rotation.x > 0) {
				walking = true;
			}

		if (GameObject.Find("Camera").transform.rotation.x < 0) {
				walking = false;
			}
			



	}
}



*/





﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 10000f;			//speed
	public bool moveForward;			//Move or Not
	private CharacterController cc;		//Character Controlled Script
	private GvrEditorEmulator gvrEditor;
	private Transform vrHead;

	private float time=0;

	void Start () {
		cc = GetComponent<CharacterController> ();
		gvrEditor = transform.GetChild (0).GetComponent<GvrEditorEmulator> ();
		vrHead = Camera.main.transform;
	}

	void Update() {
		if (GameObject.Find("Camera").transform.rotation.x < 0) {
			moveForward = false;
		}

		if (GameObject.Find("Camera").transform.rotation.x > 0) {
			moveForward = true;
		}

		if (moveForward) {
			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed*5f);
		}




		if (time > 0) {
			time = 0;
		}
		time += Time.deltaTime;
		//Debug.Log (time / 1);
	
	}


}

