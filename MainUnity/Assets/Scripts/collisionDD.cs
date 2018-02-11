using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDD : MonoBehaviour {

	void OncollisionEnter(){
		GetComponent<Renderer> ().enabled = false;
		Destroy (this);
	}
}
