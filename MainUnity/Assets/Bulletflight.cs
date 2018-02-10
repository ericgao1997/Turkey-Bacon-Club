using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletflight : MonoBehaviour {

	int lifespan;

	// Use this for initialization
	void Start () {
		Debug. Log("initialized");
		lifespan=10;
	}
	
	Vector3 xmove = new Vector3(0.5f,0f,0f);

	// Update is called once per frame
	void Update () {

		//no collision case
		if (lifespan > 0){
			transform.position += xmove;
			lifespan-=1;
		} else {
			//this.renderer.enabled = false;
			GetComponent<Renderer>().enabled = false;
			Destroy(this);
		}
		
	}
}
