using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class shoot : MonoBehaviour {

	public int count;
	public Vector3 initial;
	public Vector3 final;


	private Vector3 Getangle(){
		float x1 = GameObject.Find ("Camera").transform.rotation.x;
		float y1 = GameObject.Find ("Camera").transform.rotation.y;
		float z1 = GameObject.Find ("Camera").transform.rotation.z;
		return new Vector3 (x1,y1,z1);
	}


	private IEnumerator Wait(float delayInSecs){
		yield return new WaitForSeconds (delayInSecs);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0) {
			initial = Getangle ();
		}

		count++;

		if (count == 1000) {
			final = Getangle ();
			if (initial == final) {
				Debug.Log ("true");
			}
			count = 0;
		}


	}
		
}
*/





/* timer --> every 5 seconds 
public class shoot:MonoBehaviour{
	public int IsRunning =1;
	public int NumberofSeconds;
	public int Timer;

	public void Update(){
		if (IsRunning == 1) {
			StartCoroutine (Wait ());
		}
	
	}

	public IEnumerator Wait(){
		IsRunning = 0;
		yield return new WaitForSeconds (NumberofSeconds);
		Debug.Log ("wiiiii");
		IsRunning = 1;
		
	}
}
*/






public class shoot : MonoBehaviour {
	GameObject prefab;
	public float fireRate = 1;
	private float nextFire = 0.0F;
	public float speed = 30;

	void Start () {
		//prefab = Resources.Load ("bullet") as GameObject;
		prefab=Resources.Load("Missile (Launched)")as GameObject;
	}

	void Update() {
		if (Input.GetMouseButtonDown(0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			//GameObject projectile = Instantiate(prefab)as GameObject;
			//GameObject projectile = (GameObject)Instantiate(prefab,transform.position,Quaternion.identity);
			Vector3 angle = new Vector3 (transform.rotation.x,transform.rotation.y-88.1f,transform.rotation.z);

			GameObject projectile = (GameObject)Instantiate(prefab,transform.position+(transform.forward*2f),transform.rotation);
			projectile.transform.Rotate (0, -88.1f, 0);

			//Debug.Log(projectile.transform.rotation);
//			projectile.transform.rotation.x=transform.rotation.x;
//			projectile.transform.rotation.y = transform.rotation.y - 88.1f;
//			projectile.transform.rotation.z=transform.rotation.z;

			projectile.AddComponent<Rigidbody>();
			//projectile.AddComponent<BoxCollider> ();
			//projectile.AddComponent<collision> ();
			//projectile.transform.position = transform.position +Camera.main.transform.forward *2;
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			//rb.velocity= GameObject.Find("GvrReticlePointer").transform.forward * 40;
			rb.velocity= GameObject.Find("Camera").transform.forward * 40;

			//rb.velocity = Camera.main.transform.forward * 40;;
		}
	}

	/*
	void OnCollisonEnter(Collider other)
	{
		if (other.gameObject.name == "Capsule") {
			Destroy (other.gameObject);

		}
	}
*/

}



//float z1 = GameObject.Find ("Camera").transform.rotation.z;


