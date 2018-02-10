using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletflight : MonoBehaviour {

	int lifespan;

	// Use this for initialization
	void Start () {
		Debug. Log("initialized");
		lifespan=50;
	}
	
<<<<<<< HEAD
=======
	Vector3 heading = new Vector3(0,0,0);
>>>>>>> 4e907a39267ab7740313079947bf75190d8c15e7
	//Vector3 heading = new Vector3((float)(0.1*transform.position.x), (float)(0.1*transform.position.y), 0f);

	// Update is called once per frame
	void Update () {

		//no collision case
		if (lifespan > 0){
			//transform.position += heading;
			lifespan-=1;
		} else {
			//this.renderer.enabled = false;
			GetComponent<Renderer>().enabled = false;
			Destroy(this);
		}
		
	}
}
