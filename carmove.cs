using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour {

	// Use this for initialization
	void Start () {


		gameObject.AddComponent<Rigidbody>();
		//projectile.AddComponent<BoxCollider> ();
		//projectile.AddComponent<collision> ();
		//projectile.transform.position = transform.position +Camera.main.transform.forward *2;
		//rb.velocity= GameObject.Find("GvrReticlePointer").transform.forward * 40;




	}

	// Update is called once per frame
	void Update () {
		//Rigidbody rb = gameObject.GetComponent<Rigidbody>();

		//transform.rotation = Quaternion.LookRotation(GameObject.Find("Camera").transform.forward, GameObject.Find("Camera").transform.up);
		//rb.velocity= GameObject.Find("Player").transform.forward * 30;
		//float step =20;
		transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").transform.position, 2f*Time.deltaTime);
		//Debug.Log (transform.position);
	}
}
