using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomgenerate : MonoBehaviour {

	// Use this for initialization
	private int count;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count % 120 == 0) {
			Debug.Log (count);
			float x = Random.Range (-100,100);
			float z = Random.Range (-100,100);
			Vector3 pos = new Vector3 (x, 1.105070f, z);
			GameObject enemy = (GameObject)Instantiate(Resources.Load("radar")as GameObject,pos,transform.rotation);
			
		}
		
		//GameObject projectile = (GameObject)Instantiate(prefab,transform.position+(transform.forward*2f),transform.rotation);





	}
}
