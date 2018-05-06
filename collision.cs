using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("gg");
		//Destroy (gameObject);
		//Debug.Log ("destryoed");
	}


	void Update(){
		if (transform.position.y < -10f) {
			Destroy (gameObject);
			GameObject explode = (GameObject)Instantiate (Resources.Load("explosion"), gameObject.transform.position, gameObject.transform.rotation);
			Destroy (explode,6f);


		}
	
	}

	void OnCollisionEnter(Collision collider)
	{
		Debug.Log ("colliding " + collider.gameObject.name);

		if (!(collider.gameObject.name == "Plane")) {
			Destroy (collider.gameObject);
		}
		Destroy (gameObject);



		GameObject explode = (GameObject)Instantiate (Resources.Load("explosion"), gameObject.transform.position, gameObject.transform.rotation);
		//GameObject explodingSound = (GameObject)Instantiate (Resources.Load ("ExplosionSound"), gameObject.transform.position, gameObject.transform.rotation);



		Destroy (explode,6f);
		//Destroy (explodingSound, 6f);


			

	}

}


/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2Script : MonoBehaviour {


//	public GameObject explosion;

	void OnCollisionEnter2D(Collision2D other){
		GameObject PlayerTwo = GameObject.Find ("Player2");
		Player2Movement script = PlayerTwo.GetComponent<Player2Movement> ();
		GameObject explode = (GameObject)Instantiate (Resources.Load("Explode"), gameObject.transform.position, gameObject.transform.rotation);
		GameObject explodingSound = (GameObject)Instantiate (Resources.Load ("ExplodingSound"), gameObject.transform.position, gameObject.transform.rotation);

		Destroy (gameObject);
		Destroy (explode,3f);
		Destroy (explodingSound, 3f);


		if (other.gameObject.tag == "Player"){
			script.score += 3;

		}
		if (other.gameObject.name.Contains ("Enemy")) {
			Debug.Log ("destroying enemy");
			script.score += 1;
		}
	}



}
*/
